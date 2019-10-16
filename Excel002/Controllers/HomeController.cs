using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;

using Excel002.Filters;
using Excel002.Data;
using Excel002.Models;
using Excel002.Utilities;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.CodeAnalysis;
using ExcelDataReader;
using System.Threading;

namespace Excel002.Controllers
{
    public class HomeController : Controller
    {

        private IHostingEnvironment _hostingEnvironment;

        Guid _requestId;
        private readonly ApplicationDbContext _context;
        private readonly long _fileSizeLimit;
        private readonly ILogger<HomeController> _logger;
        private readonly string[] _permittedExtensions = { ".txt", ".xls", ".xlsx" };
        private readonly string _targetFilePath;

        // Get the default form options so that we can use them to set the default 
        // limits for request body data.
        private static readonly FormOptions _defaultFormOptions = new FormOptions();

        public HomeController(ILogger<HomeController> logger,
            ApplicationDbContext context, IConfiguration config, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _logger = logger;
            _context = context;
            _fileSizeLimit = config.GetValue<long>("FileSizeLimit");

            // To save physical files to a path provided by configuration:
            _targetFilePath = config.GetValue<string>("StoredFilesPath");

            // To save physical files to the temporary files folder, use:
            //_targetFilePath = Path.GetTempPath();
        }



        public IActionResult Index()
        {
            Guid requestId = Guid.NewGuid();

            ViewBag.GUID = requestId;


            ///   MyTask myTask = new MyTask();
            ///   myTask.RunMyTask(requestId);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }




        [HttpPost]
        [DisableFormValueModelBinding]
        [RequestSizeLimit(1000000000)]
        /// [ValidateAntiForgeryToken] /// ***  Later I have to Check this  for Security reasons. 
        public async Task<IActionResult> UploadPhysical()
        {
            if (!MultipartRequestHelper.IsMultipartContentType(Request.ContentType))
            {
                ModelState.AddModelError("File",
                    $"The request couldn't be processed (Error 1).");
                // Log error

                return BadRequest(ModelState);
            }

            var boundary = MultipartRequestHelper.GetBoundary(
                MediaTypeHeaderValue.Parse(Request.ContentType),
                _defaultFormOptions.MultipartBoundaryLengthLimit);
            var reader = new MultipartReader(boundary, HttpContext.Request.Body);
            var section = await reader.ReadNextSectionAsync();

            while (section != null)
            {
                var hasContentDispositionHeader =
                    ContentDispositionHeaderValue.TryParse(
                        section.ContentDisposition, out var contentDisposition);

                if (hasContentDispositionHeader)
                {
                    // This check assumes that there's a file
                    // present without form data. If form data
                    // is present, this method immediately fails
                    // and returns the model error.
                    if (!MultipartRequestHelper
                        .HasFileContentDisposition(contentDisposition))
                    {
                        ModelState.AddModelError("File",
                            $"The request couldn't be processed (Error 2).");
                        // Log error

                        return BadRequest(ModelState);
                    }
                    else
                    {
                        // Don't trust the file name sent by the client. To display
                        // the file name, HTML-encode the value.
                        var trustedFileNameForDisplay = WebUtility.HtmlEncode(
                                contentDisposition.FileName.Value);
                        var trustedFileNameForFileStorage = contentDisposition.FileName.Value;/// *** disable security Path.GetRandomFileName();

                        // **WARNING!**
                        // In the following example, the file is saved without
                        // scanning the file's contents. In most production
                        // scenarios, an anti-virus/anti-malware scanner API
                        // is used on the file before making the file available
                        // for download or for use by other systems. 
                        // For more information, see the topic that accompanies 
                        // this sample.

                        var streamedFileContent = await FileHelpers.ProcessStreamedFile(
                            section, contentDisposition, ModelState,
                            _permittedExtensions, _fileSizeLimit);

                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }

                        using (var targetStream = System.IO.File.Create(
                            Path.Combine(_targetFilePath, trustedFileNameForFileStorage)))
                        {
                            await targetStream.WriteAsync(streamedFileContent);

                            _logger.LogInformation(
                                "Uploaded file '{TrustedFileNameForDisplay}' saved to " +
                                "'{TargetFilePath}' as {TrustedFileNameForFileStorage}",
                                trustedFileNameForDisplay, _targetFilePath,
                                trustedFileNameForFileStorage);
                        }
                    }
                }

                // Drain any remaining section body that hasn't been consumed and
                // read the headers for the next section.
                section = await reader.ReadNextSectionAsync();
            }

            return Created(nameof(HomeController), null);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        private static Encoding GetEncoding(MultipartSection section)
        {
            var hasMediaTypeHeader =
                MediaTypeHeaderValue.TryParse(section.ContentType, out var mediaType);

            // UTF-7 is insecure and shouldn't be honored. UTF-8 succeeds in 
            // most cases.
            if (!hasMediaTypeHeader || Encoding.UTF7.Equals(mediaType.Encoding))
            {
                return Encoding.UTF8;
            }

            return mediaType.Encoding;
        }

        public IActionResult GenerateExcelFile()
        {
            Guid requestId = Guid.NewGuid();

            ViewBag.GUID = requestId;

            ProgressTracker.add(requestId, "Ready To Generate File");

            return View();
        }


        public async Task<IActionResult> GenerateAndDownloadExcelFile(Guid requestId)
        {

            string sWebRootFolder = _hostingEnvironment.WebRootPath;
            string sFileName = @"demo.xlsx";
            string URL = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, sFileName);
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            var memory = new MemoryStream();


            using (var fs = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook;
                workbook = new XSSFWorkbook();
                ISheet citySheet = workbook.CreateSheet("Cities");


                IRow row = citySheet.CreateRow(0);
                for (int i = 0; i < RandomData.Cities.Length; i++)
                {

                    row = citySheet.CreateRow(i);
                    row.CreateCell(0).SetCellValue(RandomData.Cities[i]);
                }


                for (int z = 0; z < 2; z++)
                {

                    ProgressTracker.add(requestId, "Generating  Sheet" + z.ToString());

                    ISheet invoiceSheet = workbook.CreateSheet("Invoices" + z.ToString());

                    for (Int32 i = 0; i < 1000000; i++) /// 1,048,576 Maximum Excel Row Count
                    {

                        if (i % 10000 == 0)
                        {
                            ProgressTracker.add(requestId, "Generating  Sheet" + z.ToString() + " - " + i.ToString() + " Raws of 1,048,576 Generated");
                        }
                        ///try
                        {
                            var invoice = RandomData.generateRandomItem();
                            row = invoiceSheet.CreateRow(i);
                            row.CreateCell(0).SetCellValue(invoice.city);
                            row.CreateCell(1).SetCellValue(invoice.customer);
                            row.CreateCell(2).SetCellValue(invoice.product);
                            row.CreateCell(3).SetCellValue(invoice.productCode);
                            row.CreateCell(4).SetCellValue(invoice.Price);

                        }
                        ///catch (Exception ex)
                        {

                        }
                    }
                }

                ProgressTracker.add(requestId, "Writing To File");
                workbook.Write(fs);


            }
            using (var stream = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            ProgressTracker.add(requestId, "done");
            return File(memory, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", sFileName);
        }



        public IActionResult TaskProgress(string requestId)
        {
            var statusMessage = string.Empty;

            if (!string.IsNullOrWhiteSpace(requestId))
            {
                statusMessage = ProgressTracker.getValue(Guid.Parse(requestId)).ToString();

                //The processing  has not yet finished 
                //Add a refresh header, to refresh the page in 10 seconds.
                Response.Headers.Add("Refresh", "5");
                return View("TaskProgress", statusMessage);
            }

            statusMessage = "Error: Something went wrong with process";
            return PartialView("TaskProgress", statusMessage);
        }

        public async Task<IActionResult> EmptyDb()
        {
            TablesStatusModel tm = new TablesStatusModel();
            _context.Cities.RemoveRange(_context.Cities);

            _context.Products.RemoveRange(_context.Products);
            _context.Customers.RemoveRange(_context.Customers);


            await _context.SaveChangesAsync();


            return View();
        }



        public IActionResult ParseFile()
        {
            Guid requestId = Guid.NewGuid();

            ViewBag.GUID = requestId;

             MyTask myTask = new MyTask();
             myTask.RunMyTask(requestId,_context);

            return View();
        }

             

    }


    public class FormData
    {
        public string Note { get; set; }
    }


    class UserDetails
    {
        public String ID { get; set; }
        public String Name { get; set; }
        public String City { get; set; }
        public String Country { get; set; }

    }



}

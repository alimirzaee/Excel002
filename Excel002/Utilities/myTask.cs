using Excel002.Data;
using Excel002.Models;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Excel002.Utilities
{
    public class MyTask
    {
        Guid currentRequest;
        ApplicationDbContext _db;
        public void RunMyTask(Guid requestId,ApplicationDbContext db)
        {
           
            currentRequest = requestId;
            _db = new ApplicationDbContext();

            //Your actual long running task code goes here.

            //To run task in prallel

            //Method 1
            ThreadStart tsMethod1 = new ThreadStart(Parse);
            Thread tMethod1 = new Thread(tsMethod1);
            tMethod1.Start();

         /*   //Method 2
            ThreadStart tsMethod2 = new ThreadStart(Method2);
            Thread tMethod2 = new Thread(tsMethod2);
            tMethod2.Start();*/
        }

        public void ParseExcelFile()
        {
            /// Nothing yet
            ProgressTracker.add(currentRequest, "Method 1 :: Task 1: Executing something!!!");
            System.Threading.Tasks.Task.Delay(3000).Wait();
            ProgressTracker.add(currentRequest, "Method 1 :: Task 2: Executing something!!!");
            System.Threading.Tasks.Task.Delay(3000).Wait();
            ProgressTracker.add(currentRequest, "Method 1 :: Task 3: Executing something!!!");
            System.Threading.Tasks.Task.Delay(3000).Wait();
            ProgressTracker.add(currentRequest, "done");
        }


        public void Parse()
        {
            ProgressTracker.add(currentRequest, "Start Parsing...");

            ///System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


            ProgressTracker.add(currentRequest, "Loading File...");
            FileStream stream = new FileStream(@"c:\files\1.xlsx", FileMode.Open); /// File.Open("", FileMode.Open, FileAccess.Read);
            ProgressTracker.add(currentRequest, "Reading Content...");
            
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //...
            //3. DataSet - The result of each spreadsheet will be created in the result.Tables
            DataSet result = excelReader.AsDataSet();
             
            DataTable sh1 = result.Tables[0];

            ProgressTracker.add(currentRequest, "Table Count=" + result.Tables.Count.ToString());
            foreach (DataRow r in sh1.Rows)
            {                
                City c = new City { Name=  r.ItemArray[0].ToString() };
                _db.Cities.Add(c);
                _db.SaveChanges();
            }

            for (int i = 1; i < result.Tables.Count; i++)
            {
                DataTable sh2 = result.Tables[i];

                ProgressTracker.add(currentRequest, "Parsing Table "+i.ToString()+"  Total Records=" + sh2.Rows.Count.ToString());
                int z = 0;
                foreach (DataRow r in sh2.Rows)
                {
                    z++;

                    if (z % 1000 == 0)
                    {
                        ProgressTracker.add(currentRequest, "Parsing Table 2 Record No:" + z.ToString() + " Of :" + sh2.Rows.Count.ToString() + " records");

                    }
                    var ct = _db.Cities.Where(ee => ee.Name.Equals(r[0].ToString())).FirstOrDefault();

                    var cst = _db.Customers.Where(ee => ee.Name_Family.Equals(r[1].ToString())).FirstOrDefault();
                    if (cst == null)
                    {
                        cst = new Customer { Name_Family = r[1].ToString() };
                        _db.Customers.Add(cst);
                        _db.SaveChanges();
                    }

                    var prdct = _db.Products.Where(ee => ee.Name.Equals(r[2].ToString())).FirstOrDefault();
                    if (prdct == null)
                    {
                        prdct = new Product { Name = r[2].ToString(), Code = r[3].ToString() };

                        _db.Products.Add(prdct);
                        _db.SaveChanges();
                    }

                    float price = 0;
                    try
                    {
                        price = float.Parse(r[4].ToString());
                    }
                    catch (Exception ex)
                    {
                        price = 0;
                    }
                    InvoiceItem iv = new InvoiceItem
                    {
                        CityId = ct.Id,
                        CustomerId = cst.Id,
                        ProductId = prdct.Id,
                        Price = price
                    };

                    _db.InvoiceItem.Add(iv);
                    _db.SaveChanges();
                }
            }

            //5. Data Reader methods
            while (excelReader.Read())
            {
                //excelReader.GetInt32(0);
            }

            //6. Free resources (IExcelDataReader is IDisposable)
            ProgressTracker.add(currentRequest, "done");
            excelReader.Close();
        }
    }
}

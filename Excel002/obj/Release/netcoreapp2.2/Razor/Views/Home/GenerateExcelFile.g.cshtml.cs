#pragma checksum "C:\Users\Ali\source\repos\Excel002\Excel002\Views\Home\GenerateExcelFile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef02c301de63cccf9bf4156d05987de25d5bb324"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GenerateExcelFile), @"mvc.1.0.view", @"/Views/Home/GenerateExcelFile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GenerateExcelFile.cshtml", typeof(AspNetCore.Views_Home_GenerateExcelFile))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\_ViewImports.cshtml"
using Excel002;

#line default
#line hidden
#line 2 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\_ViewImports.cshtml"
using Excel002.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef02c301de63cccf9bf4156d05987de25d5bb324", @"/Views/Home/GenerateExcelFile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b12edce9dc37848e0d0ddfc9c713645a77f3bfdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GenerateExcelFile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\Home\GenerateExcelFile.cshtml"
  
    ViewData["Title"] = "GenerateExcelFile";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(102, 111, true);
            WriteLiteral("\r\n<h1>GenerateExcelFile</h1>\r\n\r\n\r\n\r\n<button class=\'btn btn-primary\' id=\'btn\'>Generate And Export</button>\r\n\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 213, "\"", 302, 1);
#line 13 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\Home\GenerateExcelFile.cshtml"
WriteAttributeValue("", 220, Url.Action("GenerateAndDownloadExcelFile","Home",new { requestId=@ViewBag.GUID }), 220, 82, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(303, 117, true);
            WriteLiteral(" target=\"myiFrame\" >Click me!</a>\r\n\r\n \r\n\r\n <div id=\"iframeHolder\" ></div>\r\n<div id=\"iframeProgressHolder\" ></div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(437, 111, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(\"#btn\").click(function () {\r\n        \r\n            var url = \'");
                EndContext();
                BeginContext(549, 82, false);
#line 24 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\Home\GenerateExcelFile.cshtml"
                  Write(Url.Action("GenerateAndDownloadExcelFile", "Home",new { requestId=@ViewBag.GUID }));

#line default
#line hidden
                EndContext();
                BeginContext(631, 32, true);
                WriteLiteral("\';\r\n\r\n\r\n            var urlP = \'");
                EndContext();
                BeginContext(664, 65, false);
#line 27 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\Home\GenerateExcelFile.cshtml"
                   Write(Url.Action("TaskProgress","Home",new { requestId=@ViewBag.GUID }));

#line default
#line hidden
                EndContext();
                BeginContext(729, 453, true);
                WriteLiteral(@"';


      

            if (!$('#iframe').length) {
                $('#iframeHolder').html('<iframe id=""iframe"" src=' + '""'+url+'""'+' width=""0"" height=""0"" hidden=""hidden""></iframe>');
            }

            if (!$('#iframe2').length) {
                $('#iframeProgressHolder').html('<iframe id=""iframe2"" src=' + '""'+urlP+'""'+' width=""800"" height=""200"" ></iframe>');
            }
           


        });



    </script>

");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

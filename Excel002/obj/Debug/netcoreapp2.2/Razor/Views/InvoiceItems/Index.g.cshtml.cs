#pragma checksum "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c0154490f996da9f4542d1c0b285a07671d50f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvoiceItems_Index), @"mvc.1.0.view", @"/Views/InvoiceItems/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InvoiceItems/Index.cshtml", typeof(AspNetCore.Views_InvoiceItems_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c0154490f996da9f4542d1c0b285a07671d50f6", @"/Views/InvoiceItems/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b12edce9dc37848e0d0ddfc9c713645a77f3bfdf", @"/Views/_ViewImports.cshtml")]
    public class Views_InvoiceItems_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Excel002.Models.InvoiceItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(168, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c0154490f996da9f4542d1c0b285a07671d50f65697", async() => {
                BeginContext(191, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(205, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(215, 1094, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c0154490f996da9f4542d1c0b285a07671d50f67086", async() => {
                BeginContext(277, 243, true);
                WriteLiteral("\r\n\r\n    <table>\r\n        <tr>\r\n            <th>City</th>\r\n            <th>Product</th>\r\n            <th>Customer</th>\r\n            <th></th>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td>\r\n                <input id=\"CityName\" name=\"CityName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 520, "\"", 545, 1);
#line 26 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
WriteAttributeValue("", 528, ViewBag.CityName, 528, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(546, 53, true);
                WriteLiteral(" />\r\n                <input id=\"CityId\" name=\"CityId\"");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 599, "\"", 623, 1);
#line 27 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
WriteAttributeValue("", 608, ViewBag.CityId, 608, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(624, 137, true);
                WriteLiteral("  readonly=\"readonly\" hidden=\"hidden\" />\r\n            </td>\r\n            <td>\r\n                <input id=\"ProductName\" name=\"ProductName\"");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 761, "\"", 790, 1);
#line 30 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
WriteAttributeValue("", 770, ViewBag.ProductName, 770, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(791, 79, true);
                WriteLiteral(" />\r\n                <input id=\"ProductId\" name=\"ProductId\" readonly=\"readonly\"");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 870, "\"", 897, 1);
#line 31 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
WriteAttributeValue("", 879, ViewBag.ProductId, 879, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(898, 120, true);
                WriteLiteral("  hidden=\"hidden\"  />\r\n            </td>\r\n            <td>\r\n                <input id=\"CustomerName\" name=\"CustomerName\"");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 1018, "\"", 1048, 1);
#line 34 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
WriteAttributeValue("", 1027, ViewBag.CustomerName, 1027, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1049, 81, true);
                WriteLiteral(" />\r\n                <input id=\"CustomerId\" name=\"CustomerId\" readonly=\"readonly\"");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 1130, "\"", 1158, 1);
#line 35 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
WriteAttributeValue("", 1139, ViewBag.CustomerId, 1139, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1159, 143, true);
                WriteLiteral(" hidden=\"hidden\"  />\r\n            </td>\r\n            <td><input type=\"submit\" value=\"Search\" /></td>\r\n        </tr>\r\n    </table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1309, 88, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1398, 40, false);
#line 52 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.city));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1494, 44, false);
#line 55 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.customer));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 181, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Product Name\r\n            </th>\r\n            <th>\r\n                Code\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1720, 41, false);
#line 64 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1761, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 70 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1896, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1957, 44, false);
#line 74 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.city.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2001, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2069, 55, false);
#line 77 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.customer.Name_Family));

#line default
#line hidden
            EndContext();
            BeginContext(2124, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2192, 47, false);
#line 80 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2239, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2309, 47, false);
#line 84 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.product.Code));

#line default
#line hidden
            EndContext();
            BeginContext(2356, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2424, 40, false);
#line 87 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2464, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n                    ");
            EndContext();
            BeginContext(2533, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c0154490f996da9f4542d1c0b285a07671d50f616516", async() => {
                BeginContext(2581, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2592, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2616, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c0154490f996da9f4542d1c0b285a07671d50f618872", async() => {
                BeginContext(2663, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2673, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 95 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2728, 30, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2776, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 102 "C:\Users\Ali\source\repos\Excel002\Excel002\Views\InvoiceItems\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(2846, 2487, true);
                WriteLiteral(@"
    <script type=""text/javascript"">


        $(document).ready(function () {


            $('#CityName').autocomplete({
                source: '/api/city/search',
                autoFill: true,
                autocomplete: true,
                selectFirst: true, //here
                minLength: 1,
                select: function (event, ui) {
                    $('#CityName').val(ui.item.label);
                    $('#CityId').val(ui.item.value);
                    return false; // Prevent the widget from inserting the value.
                },
                focus: function (event, ui) {
                    event.preventDefault();
                    $(""#CityName"").val(ui.item.label);
                    $('#CityId').val(ui.item.value);
                }
            });



            $('#CustomerName').autocomplete({
                source: '/api/customer/search',
                autoFill: true,
                autocomplete: true,
                selectFirst: true");
                WriteLiteral(@", //here
                minLength: 1,
                select: function (event, ui) {
                    $('#CustomerName').val(ui.item.label);
                    $('#CustomerId').val(ui.item.value);
                    return false; // Prevent the widget from inserting the value.
                },
                focus: function (event, ui) {
                    event.preventDefault();
                    $(""#CustomerName"").val(ui.item.label);
                    $('#CustomerId').val(ui.item.value);
                }
            });


            $('#ProductName').autocomplete({
                source: '/api/product/search',
                autoFill: true,
                autocomplete: true,
                selectFirst: true, //here
                minLength: 1,
                select: function (event, ui) {
                    $('#ProductName').val(ui.item.label);
                    $('#ProductId').val(ui.item.value);
                    $(""#ProductCode"").val(ui.item.code);
    ");
                WriteLiteral(@"                return false; // Prevent the widget from inserting the value.
                },
                focus: function (event, ui) {
                    event.preventDefault();
                    $(""#ProductName"").val(ui.item.label);
                    $(""#ProductCode"").val(ui.item.code);

                    $('#ProductId').val(ui.item.value);
                }
            });



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Excel002.Models.InvoiceItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591

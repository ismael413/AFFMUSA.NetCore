#pragma checksum "C:\Users\user\source\repos\AFFMUSA\AFFMUSA\Views\Home\ClientDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91816c163eb89263b3bb8b053bfeff61b4de8734"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ClientDetails), @"mvc.1.0.view", @"/Views/Home/ClientDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ClientDetails.cshtml", typeof(AspNetCore.Views_Home_ClientDetails))]
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
#line 1 "C:\Users\user\source\repos\AFFMUSA\AFFMUSA\Views\_ViewImports.cshtml"
using AFFMUSA;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\AFFMUSA\AFFMUSA\Views\_ViewImports.cshtml"
using AFFMUSA.Models;

#line default
#line hidden
#line 3 "C:\Users\user\source\repos\AFFMUSA\AFFMUSA\Views\_ViewImports.cshtml"
using AFFMUSA.Models.Lists;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91816c163eb89263b3bb8b053bfeff61b4de8734", @"/Views/Home/ClientDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d286e87066029d0313f4636230f90cf58ed726", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ClientDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Client>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "clientindex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark text-black m-1 mt-0 fa fa-1x fa-arrow-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnoverview"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("showHideInfo()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("visibility: visible;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "clientlist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark text-black m-1 buttonlightred"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\user\source\repos\AFFMUSA\AFFMUSA\Views\Home\ClientDetails.cshtml"
  
    ViewBag.PageTitle = "Client Details";
    //var photoPath = "~/images/" + (Model.Photo ?? "user.png");

#line default
#line hidden
            BeginContext(133, 93, true);
            WriteLiteral("\r\n    <div class=\"row justify-content-center m-3\">\r\n       \r\n        <div class=\"col-sm-8\">\r\n");
            EndContext();
            BeginContext(291, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(303, 249, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91816c163eb89263b3bb8b053bfeff61b4de87347142", async() => {
                BeginContext(520, 28, true);
                WriteLiteral("&nbsp;&nbsp; Go Back To Menu");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(552, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(630, 104, true);
            WriteLiteral("            <div class=\"card mt-1\">\r\n                <div class=\"card-header\">\r\n                    <h1>");
            EndContext();
            BeginContext(735, 18, false);
#line 18 "C:\Users\user\source\repos\AFFMUSA\AFFMUSA\Views\Home\ClientDetails.cshtml"
                   Write(Model.Company_Name);

#line default
#line hidden
            EndContext();
            BeginContext(753, 86, true);
            WriteLiteral("</h1>\r\n                </div>\r\n\r\n                <div class=\"card-body text-center\">\r\n");
            EndContext();
            BeginContext(936, 89, true);
            WriteLiteral("                    <br />\r\n                    <h4 class=\"text-black-50\">Company Name : ");
            EndContext();
            BeginContext(1026, 18, false);
#line 24 "C:\Users\user\source\repos\AFFMUSA\AFFMUSA\Views\Home\ClientDetails.cshtml"
                                                        Write(Model.Company_Name);

#line default
#line hidden
            EndContext();
            BeginContext(1044, 67, true);
            WriteLiteral("</h4>\r\n                    <hr />\r\n                    <h4>Photo : ");
            EndContext();
            BeginContext(1112, 11, false);
#line 26 "C:\Users\user\source\repos\AFFMUSA\AFFMUSA\Views\Home\ClientDetails.cshtml"
                           Write(Model.Photo);

#line default
#line hidden
            EndContext();
            BeginContext(1123, 96, true);
            WriteLiteral("</h4>\r\n                    <hr />\r\n                    <h4 class=\"text-black-50\">Contact Name : ");
            EndContext();
            BeginContext(1220, 18, false);
#line 28 "C:\Users\user\source\repos\AFFMUSA\AFFMUSA\Views\Home\ClientDetails.cshtml"
                                                        Write(Model.Contact_Name);

#line default
#line hidden
            EndContext();
            BeginContext(1238, 71, true);
            WriteLiteral("</h4>\r\n                    <hr />\r\n                    <h4>Job Title : ");
            EndContext();
            BeginContext(1310, 15, false);
#line 30 "C:\Users\user\source\repos\AFFMUSA\AFFMUSA\Views\Home\ClientDetails.cshtml"
                               Write(Model.Job_Title);

#line default
#line hidden
            EndContext();
            BeginContext(1325, 67, true);
            WriteLiteral("</h4>\r\n                    <hr />\r\n                    <h4>Email : ");
            EndContext();
            BeginContext(1393, 11, false);
#line 32 "C:\Users\user\source\repos\AFFMUSA\AFFMUSA\Views\Home\ClientDetails.cshtml"
                           Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1404, 88, true);
            WriteLiteral("</h4>\r\n                    <hr />\r\n                    <h4 class=\"text-black-50\">City : ");
            EndContext();
            BeginContext(1493, 10, false);
#line 34 "C:\Users\user\source\repos\AFFMUSA\AFFMUSA\Views\Home\ClientDetails.cshtml"
                                                Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(1503, 67, true);
            WriteLiteral("</h4>\r\n                    <hr />\r\n                    <h4>State : ");
            EndContext();
            BeginContext(1571, 11, false);
#line 36 "C:\Users\user\source\repos\AFFMUSA\AFFMUSA\Views\Home\ClientDetails.cshtml"
                           Write(Model.State);

#line default
#line hidden
            EndContext();
            BeginContext(1582, 170, true);
            WriteLiteral("</h4>\r\n                    <br />\r\n                </div>\r\n                <div class=\"card-footer text-center bg-dark\" style=\"background:#442222;\">\r\n                    ");
            EndContext();
            BeginContext(1752, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91816c163eb89263b3bb8b053bfeff61b4de873413044", async() => {
                BeginContext(1852, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1860, 264, true);
            WriteLiteral(@"
                    <a href=""#"" class=""btn btn-dark text-black m-1 buttonlightred"">Edit</a>
                    <a href=""#"" class=""btn btn-dark text-black m-1 buttonlightred"">Delete</a>
                </div>
            </div>
        </div>
    </div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2142, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2148, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91816c163eb89263b3bb8b053bfeff61b4de873415154", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2192, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
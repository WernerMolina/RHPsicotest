#pragma checksum "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58d7dda65118025c57831881c73142acb1519e28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Test_BFQ), @"mvc.1.0.view", @"/Views/Test/Test_BFQ.cshtml")]
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
#nullable restore
#line 1 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels.Role;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels.Candidate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.Tests.Questions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58d7dda65118025c57831881c73142acb1519e28", @"/Views/Test/Test_BFQ.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58463026d13bcaa327480f71439c8fdaf43f7e4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Test_Test_BFQ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BFQ>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
  
    ViewData["Title"] = "Prueba BFQ";
    Layout = "~/Views/Shared/_Layout.cshtml";
    
    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"mb-3\">Prueba: BFQ</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58d7dda65118025c57831881c73142acb1519e285504", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
     foreach (BFQ test in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container d-flex mb-4 border-bottom\">\r\n            <div class=\" col-6 d-flex align-items-center\">\r\n                <p class=\" fs-4 px-3 m-0\">");
#nullable restore
#line 17 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
                                     Write(test.QuestionNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(". ");
#nullable restore
#line 17 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
                                                           Write(test.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <table class=\"table table-borderless m-0\">\r\n                    <thead class=\"text-center fs-5\">\r\n                        <tr");
                BeginWriteAttribute("class", " class=\"", 641, "\"", 649, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <th>
                                5
                            </th>
                            <th>
                                4
                            </th>
                            <th>
                                3
                            </th>
                            <th>
                                2
                            </th>
                            <th>
                                1
                            </th>
                        </tr>
                    </thead>
                    <tbody class=""text-center fs-5"">
                        <tr");
                BeginWriteAttribute("class", " class=\"", 1315, "\"", 1323, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 1399, "\"", 1407, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1421, "\"", 1426, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1427, "\"", 1447, 3);
                WriteAttributeValue("", 1434, "responses[", 1434, 10, true);
#nullable restore
#line 43 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 1444, i, 1444, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1446, "]", 1446, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"5\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </td>\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 1639, "\"", 1647, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1661, "\"", 1666, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1667, "\"", 1687, 3);
                WriteAttributeValue("", 1674, "responses[", 1674, 10, true);
#nullable restore
#line 47 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 1684, i, 1684, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1686, "]", 1686, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"4\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </td>\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 1879, "\"", 1887, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1901, "\"", 1906, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1907, "\"", 1927, 3);
                WriteAttributeValue("", 1914, "responses[", 1914, 10, true);
#nullable restore
#line 51 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 1924, i, 1924, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1926, "]", 1926, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"3\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </td>\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 2119, "\"", 2127, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2141, "\"", 2146, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2147, "\"", 2167, 3);
                WriteAttributeValue("", 2154, "responses[", 2154, 10, true);
#nullable restore
#line 55 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 2164, i, 2164, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2166, "]", 2166, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"2\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </td>\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 2359, "\"", 2367, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2381, "\"", 2386, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2387, "\"", 2407, 3);
                WriteAttributeValue("", 2394, "responses[", 2394, 10, true);
#nullable restore
#line 59 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 2404, i, 2404, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2406, "]", 2406, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"1\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 67 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"

        i++;
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div class=\"text-end my-3\">\r\n        <input type=\"submit\" class=\"btn btn-primary\" value=\"Terminar\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BFQ>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

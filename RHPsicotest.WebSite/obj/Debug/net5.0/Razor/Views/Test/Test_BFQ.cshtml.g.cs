#pragma checksum "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faad52c01fba9dbdb7bd6bfafafe48f9067d4f49"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faad52c01fba9dbdb7bd6bfafafe48f9067d4f49", @"/Views/Test/Test_BFQ.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58463026d13bcaa327480f71439c8fdaf43f7e4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Test_Test_BFQ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Questions_BFQ>>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faad52c01fba9dbdb7bd6bfafafe48f9067d4f495514", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
     foreach (Questions_BFQ test in Model)
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
                BeginWriteAttribute("class", " class=\"", 661, "\"", 669, 0);
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
                BeginWriteAttribute("class", " class=\"", 1335, "\"", 1343, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 1419, "\"", 1427, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1441, "\"", 1446, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1447, "\"", 1467, 3);
                WriteAttributeValue("", 1454, "responses[", 1454, 10, true);
#nullable restore
#line 43 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 1464, i, 1464, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1466, "]", 1466, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"5\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </td>\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 1659, "\"", 1667, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1681, "\"", 1686, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1687, "\"", 1707, 3);
                WriteAttributeValue("", 1694, "responses[", 1694, 10, true);
#nullable restore
#line 47 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 1704, i, 1704, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1706, "]", 1706, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"4\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </td>\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 1899, "\"", 1907, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1921, "\"", 1926, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1927, "\"", 1947, 3);
                WriteAttributeValue("", 1934, "responses[", 1934, 10, true);
#nullable restore
#line 51 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 1944, i, 1944, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1946, "]", 1946, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"3\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </td>\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 2139, "\"", 2147, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2161, "\"", 2166, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2167, "\"", 2187, 3);
                WriteAttributeValue("", 2174, "responses[", 2174, 10, true);
#nullable restore
#line 55 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 2184, i, 2184, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2186, "]", 2186, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"2\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </td>\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 2379, "\"", 2387, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2401, "\"", 2406, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2407, "\"", 2427, 3);
                WriteAttributeValue("", 2414, "responses[", 2414, 10, true);
#nullable restore
#line 59 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 2424, i, 2424, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2426, "]", 2426, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Questions_BFQ>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

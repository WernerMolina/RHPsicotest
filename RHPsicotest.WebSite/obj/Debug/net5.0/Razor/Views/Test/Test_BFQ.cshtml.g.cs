#pragma checksum "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29894e901a38a94bb5658905b92dd2a8d37b8157"
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
#line 1 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels.Role;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels.Candidate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.Tests.Questions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29894e901a38a94bb5658905b92dd2a8d37b8157", @"/Views/Test/Test_BFQ.cshtml")]
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
#line 3 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
  
    ViewData["Title"] = "Prueba BFQ";
    Layout = "~/Views/Shared/_Layout.cshtml";
    
    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"mb-3\">Prueba BFQ</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29894e901a38a94bb5658905b92dd2a8d37b81575513", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
     foreach (Questions_BFQ test in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container d-flex mb-4 border-bottom\">\r\n            <div class=\" col-6 d-flex align-items-center\">\r\n                <p class=\" fs-4 px-3 m-0\">");
#nullable restore
#line 17 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
                                     Write(test.QuestionNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(". ");
#nullable restore
#line 17 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
                                                           Write(test.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <table class=\"table table-borderless m-0\">\r\n                    <thead class=\"text-center fs-5\">\r\n                        <tr");
                BeginWriteAttribute("class", " class=\"", 660, "\"", 668, 0);
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
                BeginWriteAttribute("class", " class=\"", 1334, "\"", 1342, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 1418, "\"", 1426, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1440, "\"", 1445, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1446, "\"", 1466, 3);
                WriteAttributeValue("", 1453, "responses[", 1453, 10, true);
#nullable restore
#line 43 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 1463, i, 1463, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1465, "]", 1465, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"5\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </td>\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 1658, "\"", 1666, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1680, "\"", 1685, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1686, "\"", 1706, 3);
                WriteAttributeValue("", 1693, "responses[", 1693, 10, true);
#nullable restore
#line 47 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 1703, i, 1703, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1705, "]", 1705, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"4\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </td>\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 1898, "\"", 1906, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1920, "\"", 1925, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1926, "\"", 1946, 3);
                WriteAttributeValue("", 1933, "responses[", 1933, 10, true);
#nullable restore
#line 51 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 1943, i, 1943, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1945, "]", 1945, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"3\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </td>\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 2138, "\"", 2146, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2160, "\"", 2165, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2166, "\"", 2186, 3);
                WriteAttributeValue("", 2173, "responses[", 2173, 10, true);
#nullable restore
#line 55 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 2183, i, 2183, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2185, "]", 2185, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"2\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </td>\r\n                            <td>\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 2378, "\"", 2386, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2400, "\"", 2405, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2406, "\"", 2426, 3);
                WriteAttributeValue("", 2413, "responses[", 2413, 10, true);
#nullable restore
#line 59 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 2423, i, 2423, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2425, "]", 2425, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"1\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 67 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"

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

#pragma checksum "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e7018b4c06356bae91b74079a61290297c71cf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Test_OTIS), @"mvc.1.0.view", @"/Views/Test/Test_OTIS.cshtml")]
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
#line 1 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels.Role;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels.Candidate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.Tests.Questions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e7018b4c06356bae91b74079a61290297c71cf9", @"/Views/Test/Test_OTIS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58463026d13bcaa327480f71439c8fdaf43f7e4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Test_Test_OTIS : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OTIS>>
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
#line 3 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
  
    ViewData["Title"] = "Prueba OTIS";
    Layout = "~/Views/Shared/_Layout.cshtml";
    
    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"mb-3\">Prueba: OTIS</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e7018b4c06356bae91b74079a61290297c71cf95535", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
     foreach (OTIS test in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"card col-8 my-2\">\r\n            <div class=\"card-header h5\">\r\n                ");
#nullable restore
#line 17 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
           Write(test.QuestionNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(". ");
#nullable restore
#line 17 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                                 Write(test.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body d-flex gap-5\">\r\n                <div class=\"w-75 d-flex flex-column gap-3\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            A) ");
#nullable restore
#line 23 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                          Write(test.OptionA);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            B) ");
#nullable restore
#line 28 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                          Write(test.OptionB);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            C) ");
#nullable restore
#line 33 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                          Write(test.OptionC);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            D) ");
#nullable restore
#line 38 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                          Write(test.OptionD);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            E) ");
#nullable restore
#line 43 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                          Write(test.OptionE);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"d-flex flex-column gap-2\">\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 1633, "\"", 1666, 2);
                WriteAttributeValue("", 1638, "optionA-", 1638, 8, true);
#nullable restore
#line 48 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 1646, test.QuestionNumber, 1646, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 1805, "\"", 1813, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1827, "\"", 1832, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1833, "\"", 1853, 3);
                WriteAttributeValue("", 1840, "responses[", 1840, 10, true);
#nullable restore
#line 51 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 1850, i, 1850, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1852, "]", 1852, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"A\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 2098, "\"", 2131, 2);
                WriteAttributeValue("", 2103, "optionB-", 2103, 8, true);
#nullable restore
#line 56 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 2111, test.QuestionNumber, 2111, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 2270, "\"", 2278, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2292, "\"", 2297, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2298, "\"", 2318, 3);
                WriteAttributeValue("", 2305, "responses[", 2305, 10, true);
#nullable restore
#line 59 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 2315, i, 2315, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2317, "]", 2317, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"B\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 2563, "\"", 2596, 2);
                WriteAttributeValue("", 2568, "optionC-", 2568, 8, true);
#nullable restore
#line 64 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 2576, test.QuestionNumber, 2576, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 2735, "\"", 2743, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2757, "\"", 2762, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2763, "\"", 2783, 3);
                WriteAttributeValue("", 2770, "responses[", 2770, 10, true);
#nullable restore
#line 67 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 2780, i, 2780, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2782, "]", 2782, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"C\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 3028, "\"", 3061, 2);
                WriteAttributeValue("", 3033, "optionD-", 3033, 8, true);
#nullable restore
#line 72 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 3041, test.QuestionNumber, 3041, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 3200, "\"", 3208, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 3222, "\"", 3227, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 3228, "\"", 3248, 3);
                WriteAttributeValue("", 3235, "responses[", 3235, 10, true);
#nullable restore
#line 75 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 3245, i, 3245, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3247, "]", 3247, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"D\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 3493, "\"", 3526, 2);
                WriteAttributeValue("", 3498, "optionE-", 3498, 8, true);
#nullable restore
#line 80 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 3506, test.QuestionNumber, 3506, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 3665, "\"", 3673, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 3687, "\"", 3692, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 3693, "\"", 3713, 3);
                WriteAttributeValue("", 3700, "responses[", 3700, 10, true);
#nullable restore
#line 83 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 3710, i, 3710, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3712, "]", 3712, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"E\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 91 "C:\Users\Mclovin\Documents\Psicotest\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"

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
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OTIS>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

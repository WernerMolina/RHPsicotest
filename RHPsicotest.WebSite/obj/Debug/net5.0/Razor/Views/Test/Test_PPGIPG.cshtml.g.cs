#pragma checksum "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55dad12da4f7e66f45a729586e76268cab7ae1f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Test_PPGIPG), @"mvc.1.0.view", @"/Views/Test/Test_PPGIPG.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55dad12da4f7e66f45a729586e76268cab7ae1f8", @"/Views/Test/Test_PPGIPG.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58463026d13bcaa327480f71439c8fdaf43f7e4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Test_Test_PPGIPG : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PPGIPG>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Test_PPGIPG", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
  
    ViewData["Title"] = "Prueba-PPG-IPG";
    Layout = "~/Views/Shared/_Layout.cshtml";

    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Prueba: PPG-IPG</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55dad12da4f7e66f45a729586e76268cab7ae1f85816", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
     foreach (PPGIPG question in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"card my-2\">\r\n            <h5 class=\"card-header\">Pregunta ");
#nullable restore
#line 15 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
                                        Write(question.QuestionNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <div class=\"card-body d-flex gap-5\">\r\n                <div class=\"w-75 d-flex flex-column gap-3\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            A) ");
#nullable restore
#line 20 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
                          Write(question.OptionA);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            B) ");
#nullable restore
#line 25 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
                          Write(question.OptionB);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            C) ");
#nullable restore
#line 30 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
                          Write(question.OptionC);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            D) ");
#nullable restore
#line 35 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
                          Write(question.OptionD);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"d-flex flex-column gap-2\">\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 1428, "\"", 1465, 2);
                WriteAttributeValue("", 1433, "optionA-", 1433, 8, true);
#nullable restore
#line 40 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
WriteAttributeValue("", 1441, question.QuestionNumber, 1441, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 1604, "\"", 1612, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1626, "\"", 1631, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1632, "\"", 1655, 3);
                WriteAttributeValue("", 1639, "responses[", 1639, 10, true);
#nullable restore
#line 43 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
WriteAttributeValue("", 1649, i, 1649, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1651, "][0]", 1651, 4, true);
                EndWriteAttribute();
                WriteLiteral(@" value=""A""
                                   style=""width:25px; height: 25px""/>
                            </div>
                        </div>
                        <div class=""card"">
                            <div class=""card-body"">
                                <input");
                BeginWriteAttribute("class", " class=\"", 1942, "\"", 1950, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1964, "\"", 1969, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1970, "\"", 1993, 3);
                WriteAttributeValue("", 1977, "responses[", 1977, 10, true);
#nullable restore
#line 49 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
WriteAttributeValue("", 1987, i, 1987, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1989, "][1]", 1989, 4, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"A\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 2238, "\"", 2275, 2);
                WriteAttributeValue("", 2243, "optionB-", 2243, 8, true);
#nullable restore
#line 54 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
WriteAttributeValue("", 2251, question.QuestionNumber, 2251, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 2414, "\"", 2422, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2436, "\"", 2441, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2442, "\"", 2465, 3);
                WriteAttributeValue("", 2449, "responses[", 2449, 10, true);
#nullable restore
#line 57 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
WriteAttributeValue("", 2459, i, 2459, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2461, "][0]", 2461, 4, true);
                EndWriteAttribute();
                WriteLiteral(@" value=""B""
                                   style=""width:25px; height: 25px""/>
                            </div>
                        </div>
                        <div class=""card"">
                            <div class=""card-body"">
                                <input");
                BeginWriteAttribute("class", " class=\"", 2752, "\"", 2760, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2774, "\"", 2779, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2780, "\"", 2803, 3);
                WriteAttributeValue("", 2787, "responses[", 2787, 10, true);
#nullable restore
#line 63 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
WriteAttributeValue("", 2797, i, 2797, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2799, "][1]", 2799, 4, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"B\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 3048, "\"", 3085, 2);
                WriteAttributeValue("", 3053, "optionC-", 3053, 8, true);
#nullable restore
#line 68 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
WriteAttributeValue("", 3061, question.QuestionNumber, 3061, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 3224, "\"", 3232, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 3246, "\"", 3251, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 3252, "\"", 3275, 3);
                WriteAttributeValue("", 3259, "responses[", 3259, 10, true);
#nullable restore
#line 71 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
WriteAttributeValue("", 3269, i, 3269, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3271, "][0]", 3271, 4, true);
                EndWriteAttribute();
                WriteLiteral(@" value=""C""
                                   style=""width:25px; height: 25px"" />
                            </div>
                        </div>
                        <div class=""card"">
                            <div class=""card-body"">
                                <input");
                BeginWriteAttribute("class", " class=\"", 3563, "\"", 3571, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 3585, "\"", 3590, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 3591, "\"", 3614, 3);
                WriteAttributeValue("", 3598, "responses[", 3598, 10, true);
#nullable restore
#line 77 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
WriteAttributeValue("", 3608, i, 3608, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3610, "][1]", 3610, 4, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"C\"\r\n                                   style=\"width:25px; height: 25px\"/>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 3858, "\"", 3895, 2);
                WriteAttributeValue("", 3863, "optionD-", 3863, 8, true);
#nullable restore
#line 82 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
WriteAttributeValue("", 3871, question.QuestionNumber, 3871, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 4034, "\"", 4042, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 4056, "\"", 4061, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 4062, "\"", 4085, 3);
                WriteAttributeValue("", 4069, "responses[", 4069, 10, true);
#nullable restore
#line 85 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
WriteAttributeValue("", 4079, i, 4079, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4081, "][0]", 4081, 4, true);
                EndWriteAttribute();
                WriteLiteral(@" value=""D""
                                   style=""width:25px; height: 25px"" />
                            </div>
                        </div>
                        <div class=""card"">
                            <div class=""card-body"">
                                <input");
                BeginWriteAttribute("class", " class=\"", 4373, "\"", 4381, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 4395, "\"", 4400, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 4401, "\"", 4424, 3);
                WriteAttributeValue("", 4408, "responses[", 4408, 10, true);
#nullable restore
#line 91 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"
WriteAttributeValue("", 4418, i, 4418, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4420, "][1]", 4420, 4, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"D\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 99 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_PPGIPG.cshtml"

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        let inputsRadiosAll = document.querySelectorAll(""input[type=radio]"");

        inputsRadiosAll.forEach(input => input.addEventListener(""click"", uncheck));

        function uncheck(event) {
            let parent = event.target.parentNode.parentNode.parentNode;
            let inputsParent = document.querySelectorAll(`#${parent.id} input[type=radio]`);
            let isChecked = inputsParent[0] == event.target;

            isChecked ? inputsParent[1].checked = false : inputsParent[0].checked = false;
        }

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PPGIPG>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

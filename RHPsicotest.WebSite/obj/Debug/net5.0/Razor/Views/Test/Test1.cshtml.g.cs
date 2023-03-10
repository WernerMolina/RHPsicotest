#pragma checksum "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfda028c6fc3c47adfb61c838382e8e32046df0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Test1), @"mvc.1.0.view", @"/Views/Test/Test1.cshtml")]
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
using RHPsicotest.WebSite.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfda028c6fc3c47adfb61c838382e8e32046df0c", @"/Views/Test/Test1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d7466d48c5cb4b395b1493544e93aacaa11cf07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Test_Test1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Test>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Test1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
  
    ViewData["Title"] = "Prueba-PPG-IPG";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int i = 0;

    var factores = (string[])ViewBag.Factores;
    var puntajes = (byte[])ViewBag.Puntajes;
    var percentiles = (byte[])ViewBag.Percentiles;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
 if (ViewBag.Factores != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-striped table-borderless align-middle my-3"">
        <thead class=""table-dark"">
            <tr class=""text-center"">
                <th class=""fs-bold"">
                    Factor
                </th>
                <th class=""fs-bold"">
                    Puntaje
                </th>
                <th class=""fs-bold"">
                    Percentil
                </th>
            </tr>
        </thead>
        <tbody class=""text-center"">
");
#nullable restore
#line 30 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
             for (int j = 0; j <= 8; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
                   Write(factores[j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
                   Write(puntajes[j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
                   Write(percentiles[j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 47 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Prueba: ");
#nullable restore
#line 51 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
       Write(Model.NameTest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfda028c6fc3c47adfb61c838382e8e32046df0c8211", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
     foreach (var question in Model.Questions)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"card my-2\">\r\n            <h5 class=\"card-header\">Pregunta ");
#nullable restore
#line 56 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
                                        Write(question.QuestionNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <div class=\"card-body d-flex gap-5\">\r\n                <div class=\"w-75 d-flex flex-column gap-3\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            A) ");
#nullable restore
#line 61 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
                          Write(question.OptionA);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            B) ");
#nullable restore
#line 66 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
                          Write(question.OptionB);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            C) ");
#nullable restore
#line 71 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
                          Write(question.OptionC);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            D) ");
#nullable restore
#line 76 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
                          Write(question.OptionD);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"d-flex flex-column gap-2\">\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 2534, "\"", 2571, 2);
                WriteAttributeValue("", 2539, "optionA-", 2539, 8, true);
#nullable restore
#line 81 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
WriteAttributeValue("", 2547, question.QuestionNumber, 2547, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 2710, "\"", 2718, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2732, "\"", 2737, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2738, "\"", 2761, 3);
                WriteAttributeValue("", 2745, "responses[", 2745, 10, true);
#nullable restore
#line 84 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
WriteAttributeValue("", 2755, i, 2755, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2757, "][0]", 2757, 4, true);
                EndWriteAttribute();
                WriteLiteral(@" value=""A""
                                   style=""width:25px; height: 25px"" />
                            </div>
                        </div>
                        <div class=""card"">
                            <div class=""card-body"">
                                <input");
                BeginWriteAttribute("class", " class=\"", 3049, "\"", 3057, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 3071, "\"", 3076, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 3077, "\"", 3100, 3);
                WriteAttributeValue("", 3084, "responses[", 3084, 10, true);
#nullable restore
#line 90 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
WriteAttributeValue("", 3094, i, 3094, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3096, "][1]", 3096, 4, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"A\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 3345, "\"", 3382, 2);
                WriteAttributeValue("", 3350, "optionB-", 3350, 8, true);
#nullable restore
#line 95 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
WriteAttributeValue("", 3358, question.QuestionNumber, 3358, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 3521, "\"", 3529, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 3543, "\"", 3548, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 3549, "\"", 3572, 3);
                WriteAttributeValue("", 3556, "responses[", 3556, 10, true);
#nullable restore
#line 98 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
WriteAttributeValue("", 3566, i, 3566, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3568, "][0]", 3568, 4, true);
                EndWriteAttribute();
                WriteLiteral(@" value=""B""
                                   style=""width:25px; height: 25px"" checked />
                            </div>
                        </div>
                        <div class=""card"">
                            <div class=""card-body"">
                                <input");
                BeginWriteAttribute("class", " class=\"", 3868, "\"", 3876, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 3890, "\"", 3895, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 3896, "\"", 3919, 3);
                WriteAttributeValue("", 3903, "responses[", 3903, 10, true);
#nullable restore
#line 104 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
WriteAttributeValue("", 3913, i, 3913, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3915, "][1]", 3915, 4, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"B\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 4164, "\"", 4201, 2);
                WriteAttributeValue("", 4169, "optionC-", 4169, 8, true);
#nullable restore
#line 109 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
WriteAttributeValue("", 4177, question.QuestionNumber, 4177, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 4340, "\"", 4348, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 4362, "\"", 4367, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 4368, "\"", 4391, 3);
                WriteAttributeValue("", 4375, "responses[", 4375, 10, true);
#nullable restore
#line 112 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
WriteAttributeValue("", 4385, i, 4385, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4387, "][0]", 4387, 4, true);
                EndWriteAttribute();
                WriteLiteral(@" value=""C""
                                   style=""width:25px; height: 25px"" />
                            </div>
                        </div>
                        <div class=""card"">
                            <div class=""card-body"">
                                <input");
                BeginWriteAttribute("class", " class=\"", 4679, "\"", 4687, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 4701, "\"", 4706, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 4707, "\"", 4730, 3);
                WriteAttributeValue("", 4714, "responses[", 4714, 10, true);
#nullable restore
#line 118 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
WriteAttributeValue("", 4724, i, 4724, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4726, "][1]", 4726, 4, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"C\"\r\n                                   style=\"width:25px; height: 25px\" checked />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 4983, "\"", 5020, 2);
                WriteAttributeValue("", 4988, "optionD-", 4988, 8, true);
#nullable restore
#line 123 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
WriteAttributeValue("", 4996, question.QuestionNumber, 4996, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 5159, "\"", 5167, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 5181, "\"", 5186, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 5187, "\"", 5210, 3);
                WriteAttributeValue("", 5194, "responses[", 5194, 10, true);
#nullable restore
#line 126 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
WriteAttributeValue("", 5204, i, 5204, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5206, "][0]", 5206, 4, true);
                EndWriteAttribute();
                WriteLiteral(@" value=""D""
                                   style=""width:25px; height: 25px"" />
                            </div>
                        </div>
                        <div class=""card"">
                            <div class=""card-body"">
                                <input");
                BeginWriteAttribute("class", " class=\"", 5498, "\"", 5506, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 5520, "\"", 5525, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 5526, "\"", 5549, 3);
                WriteAttributeValue("", 5533, "responses[", 5533, 10, true);
#nullable restore
#line 132 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"
WriteAttributeValue("", 5543, i, 5543, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5545, "][1]", 5545, 4, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"D\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 140 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test1.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

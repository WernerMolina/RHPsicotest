#pragma checksum "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f50cafa7aeeae0807fcf1612024158013f51d04"
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
using RHPsicotest.WebSite.Tests.Questions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f50cafa7aeeae0807fcf1612024158013f51d04", @"/Views/Test/Test_OTIS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c86a5a40892f639e05d9df1ae851b57face202f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Test_Test_OTIS : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OTIS>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Test_OTIS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
  
    ViewData["Title"] = "Prueba OTIS";
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
#line 13 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
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
#line 30 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
             for (int j = 0; j <= 8; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                   Write(factores[j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                   Write(puntajes[j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                   Write(percentiles[j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 47 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Prueba: OTIS</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f50cafa7aeeae0807fcf1612024158013f51d048265", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
     foreach (OTIS test in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"card col-8 my-2\">\r\n            <div class=\"card-header h5\">\r\n                ");
#nullable restore
#line 57 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
           Write(test.QuestionNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(". ");
#nullable restore
#line 57 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                                 Write(test.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body d-flex gap-5\">\r\n                <div class=\"w-75 d-flex flex-column gap-3\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            A) ");
#nullable restore
#line 63 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                          Write(test.OptionA);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            B) ");
#nullable restore
#line 68 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                          Write(test.OptionB);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            C) ");
#nullable restore
#line 73 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                          Write(test.OptionC);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            D) ");
#nullable restore
#line 78 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                          Write(test.OptionD);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            E) ");
#nullable restore
#line 83 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
                          Write(test.OptionE);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"d-flex flex-column gap-2\">\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 2750, "\"", 2783, 2);
                WriteAttributeValue("", 2755, "optionA-", 2755, 8, true);
#nullable restore
#line 88 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 2763, test.QuestionNumber, 2763, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 2922, "\"", 2930, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2944, "\"", 2949, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2950, "\"", 2970, 3);
                WriteAttributeValue("", 2957, "responses[", 2957, 10, true);
#nullable restore
#line 91 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 2967, i, 2967, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2969, "]", 2969, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"A\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 3215, "\"", 3248, 2);
                WriteAttributeValue("", 3220, "optionB-", 3220, 8, true);
#nullable restore
#line 96 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 3228, test.QuestionNumber, 3228, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 3387, "\"", 3395, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 3409, "\"", 3414, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 3415, "\"", 3435, 3);
                WriteAttributeValue("", 3422, "responses[", 3422, 10, true);
#nullable restore
#line 99 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 3432, i, 3432, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3434, "]", 3434, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"B\"\r\n                                   style=\"width:25px; height: 25px\" checked />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 3688, "\"", 3721, 2);
                WriteAttributeValue("", 3693, "optionC-", 3693, 8, true);
#nullable restore
#line 104 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 3701, test.QuestionNumber, 3701, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 3860, "\"", 3868, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 3882, "\"", 3887, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 3888, "\"", 3908, 3);
                WriteAttributeValue("", 3895, "responses[", 3895, 10, true);
#nullable restore
#line 107 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 3905, i, 3905, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3907, "]", 3907, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"C\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 4153, "\"", 4186, 2);
                WriteAttributeValue("", 4158, "optionD-", 4158, 8, true);
#nullable restore
#line 112 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 4166, test.QuestionNumber, 4166, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 4325, "\"", 4333, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 4347, "\"", 4352, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 4353, "\"", 4373, 3);
                WriteAttributeValue("", 4360, "responses[", 4360, 10, true);
#nullable restore
#line 115 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 4370, i, 4370, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4372, "]", 4372, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"D\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\" d-flex align-items-start gap-2\"");
                BeginWriteAttribute("id", " id=\"", 4618, "\"", 4651, 2);
                WriteAttributeValue("", 4623, "optionE-", 4623, 8, true);
#nullable restore
#line 120 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 4631, test.QuestionNumber, 4631, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <input");
                BeginWriteAttribute("class", " class=\"", 4790, "\"", 4798, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 4812, "\"", 4817, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 4818, "\"", 4838, 3);
                WriteAttributeValue("", 4825, "responses[", 4825, 10, true);
#nullable restore
#line 123 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"
WriteAttributeValue("", 4835, i, 4835, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4837, "]", 4837, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"E\"\r\n                                   style=\"width:25px; height: 25px\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 131 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_OTIS.cshtml"

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
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OTIS>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

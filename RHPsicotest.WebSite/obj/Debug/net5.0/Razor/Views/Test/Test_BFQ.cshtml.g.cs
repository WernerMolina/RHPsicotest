#pragma checksum "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a809491d817204d0129f9280d90d2e040cc3f262"
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
#line 1 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels.Role;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels.Candidate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using RHPsicotest.WebSite.Tests.Questions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a809491d817204d0129f9280d90d2e040cc3f262", @"/Views/Test/Test_BFQ.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"009ee07ee2b96682d536e74a1e08408ea8d628a8", @"/Views/_ViewImports.cshtml")]
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
#line 3 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
  
    ViewData["Title"] = "Prueba Big Five";
    Layout = "~/Views/Shared/_Layout.cshtml";
    
    byte i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 164, "\"", 172, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""example"">
    <div class=""card"">
        <div class=""card-body"">
            <h1 class=""card-title h2 "">Instrucciones Generales</h1>
            <div class=""card-text fs-5 mb-4"">
                <p class=""mb-3"">
                    A continuación, encontrará una serie de frases sobre formas de pensar, sentir o actuar. Para que las vaya leyendo atentamente y marque la respuesta que describa mejor cuál es su forma habitual de pensar, sentir o actuar.
                </p>
                <p class=""mb-3"">
                    Para contestar debe seleccionar  los números del 5 - 1 de acuerdo a las siguientes alternativas:
                </p>
                <p class=""mb-3"">
                    <b>5 Completamente VERDADERO para mí</b>
                </p>
                <p class=""mb-3"">
                    <b>4 Bastante VERDADERO para mí</b>
                </p>
                <p class=""mb-3"">
                    <b>3 Ni VERDADERO ni FALSO para mí </b>
                </p>
               ");
            WriteLiteral(@" <p class=""mb-3"">
                    <b>2 Bastante FALSO para mí</b>
                </p>
                <p class=""mb-3"">
                    <b>1 Completamente FALSO para mí</b>
                </p>
            </div>

            <hr />

            <div class=""my-4"">
                <div class=""container d-flex mb-4 border-bottom"">
                    <div class="" col-6 d-flex align-items-center"">
                        <p class="" fs-4 px-3 m-0"">E1. Me gusta pasear por el parque de la cuidad.</p>
                    </div>
                    <div class=""col-6"">
                        <table class=""table table-borderless m-0"">
                            <thead class=""text-center fs-5"">
                                <tr");
            BeginWriteAttribute("class", " class=\"", 1953, "\"", 1961, 0);
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
            BeginWriteAttribute("class", " class=\"", 2779, "\"", 2787, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <td>\r\n                                        <input");
            BeginWriteAttribute("class", " class=\"", 2879, "\"", 2887, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""radio"" name=""responses[500]"" value=""5""
                                               style=""width:25px; height: 25px"" />
                                    </td>
                                    <td>
                                        <input");
            BeginWriteAttribute("class", " class=\"", 3150, "\"", 3158, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""radio"" name=""responses[500]"" value=""4""
                                               style=""width:25px; height: 25px"" />
                                    </td>
                                    <td>
                                        <input");
            BeginWriteAttribute("class", " class=\"", 3421, "\"", 3429, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""radio"" name=""responses[500]"" value=""3""
                                               style=""width:25px; height: 25px"" />
                                    </td>
                                    <td>
                                        <input");
            BeginWriteAttribute("class", " class=\"", 3692, "\"", 3700, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""radio"" name=""responses[500]"" value=""2""
                                               style=""width:25px; height: 25px"" />
                                    </td>
                                    <td>
                                        <input");
            BeginWriteAttribute("class", " class=\"", 3963, "\"", 3971, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""radio"" name=""responses[500]"" value=""1""
                                               style=""width:25px; height: 25px"" />
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""container d-flex mb-4 border-bottom"">
                    <div class="" col-6 d-flex align-items-center"">
                        <p class="" fs-4 px-3 m-0"">E2. La familia es el móvil de todos mis contactos.</p>
                    </div>
                    <div class=""col-6"">
                        <table class=""table table-borderless m-0"">
                            <thead class=""text-center fs-5"">
                                <tr");
            BeginWriteAttribute("class", " class=\"", 4784, "\"", 4792, 0);
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
            BeginWriteAttribute("class", " class=\"", 5610, "\"", 5618, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <td>\r\n                                        <input");
            BeginWriteAttribute("class", " class=\"", 5710, "\"", 5718, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""radio"" name=""responses[501]"" value=""5""
                                               style=""width:25px; height: 25px"" />
                                    </td>
                                    <td>
                                        <input");
            BeginWriteAttribute("class", " class=\"", 5981, "\"", 5989, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""radio"" name=""responses[501]"" value=""4""
                                               style=""width:25px; height: 25px"" />
                                    </td>
                                    <td>
                                        <input");
            BeginWriteAttribute("class", " class=\"", 6252, "\"", 6260, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""radio"" name=""responses[501]"" value=""3""
                                               style=""width:25px; height: 25px"" />
                                    </td>
                                    <td>
                                        <input");
            BeginWriteAttribute("class", " class=\"", 6523, "\"", 6531, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""radio"" name=""responses[501]"" value=""2""
                                               style=""width:25px; height: 25px"" />
                                    </td>
                                    <td>
                                        <input");
            BeginWriteAttribute("class", " class=\"", 6794, "\"", 6802, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""radio"" name=""responses[501]"" value=""1""
                                               style=""width:25px; height: 25px"" />
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <h4 class=""card-title fw-bold"">COMIENCE A COMPLETAR LA EVALUACIÓN.</h4>
            <div class=""card-text fs-5"">
                <p class=""mb-3"">
                    No existen respuestas correctas o incorrectas. Procure contestar  a todas las frases. Recuerde que debe dar su propia  opinión acerca de usted. Trate de ser sincero consigo mismo y contestar con espontaneidad sin pensarlo demasiado.
                </p>
            </div>
            <div class=""text-end"">
                <button class=""btn btn-primary"" onclick=""startTest()"">Empezar</button>
            </div>
        </div>
    </div>
</div>
<div id=""test"" class=""d-none"">");
            WriteLiteral(" \r\n    <h1 class=\"mb-3\">Prueba Big Five</h1>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a809491d817204d0129f9280d90d2e040cc3f26215593", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 162 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
         foreach (Questions_BFQ test in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"container d-flex mb-4 border-bottom\">\r\n                <div class=\" col-6 d-flex align-items-center\">\r\n                    <p class=\" fs-4 px-3 m-0\">");
#nullable restore
#line 166 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
                                         Write(test.QuestionNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(". ");
#nullable restore
#line 166 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
                                                               Write(test.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"col-6\">\r\n                    <table class=\"table table-borderless m-0\">\r\n                        <thead class=\"text-center fs-5\">\r\n                            <tr");
                BeginWriteAttribute("class", " class=\"", 8389, "\"", 8397, 0);
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
                BeginWriteAttribute("class", " class=\"", 9139, "\"", 9147, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <td>\r\n                                    <input");
                BeginWriteAttribute("class", " class=\"", 9231, "\"", 9239, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 9253, "\"", 9258, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 9259, "\"", 9279, 3);
                WriteAttributeValue("", 9266, "responses[", 9266, 10, true);
#nullable restore
#line 192 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 9276, i, 9276, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 9278, "]", 9278, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"5\"\r\n                                       style=\"width:25px; height: 25px\" />\r\n                                </td>\r\n                                <td>\r\n                                    <input");
                BeginWriteAttribute("class", " class=\"", 9487, "\"", 9495, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 9509, "\"", 9514, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 9515, "\"", 9535, 3);
                WriteAttributeValue("", 9522, "responses[", 9522, 10, true);
#nullable restore
#line 196 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 9532, i, 9532, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 9534, "]", 9534, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"4\"\r\n                                       style=\"width:25px; height: 25px\" />\r\n                                </td>\r\n                                <td>\r\n                                    <input");
                BeginWriteAttribute("class", " class=\"", 9743, "\"", 9751, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 9765, "\"", 9770, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 9771, "\"", 9791, 3);
                WriteAttributeValue("", 9778, "responses[", 9778, 10, true);
#nullable restore
#line 200 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 9788, i, 9788, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 9790, "]", 9790, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"3\"\r\n                                       style=\"width:25px; height: 25px\" />\r\n                                </td>\r\n                                <td>\r\n                                    <input");
                BeginWriteAttribute("class", " class=\"", 9999, "\"", 10007, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 10021, "\"", 10026, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 10027, "\"", 10047, 3);
                WriteAttributeValue("", 10034, "responses[", 10034, 10, true);
#nullable restore
#line 204 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 10044, i, 10044, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 10046, "]", 10046, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"2\"\r\n                                       style=\"width:25px; height: 25px\" />\r\n                                </td>\r\n                                <td>\r\n                                    <input");
                BeginWriteAttribute("class", " class=\"", 10255, "\"", 10263, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 10277, "\"", 10282, 0);
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 10283, "\"", 10303, 3);
                WriteAttributeValue("", 10290, "responses[", 10290, 10, true);
#nullable restore
#line 208 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"
WriteAttributeValue("", 10300, i, 10300, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 10302, "]", 10302, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" value=""1""
                                       style=""width:25px; height: 25px"" />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
");
#nullable restore
#line 216 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Test\Test_BFQ.cshtml"

            i++;
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"text-end my-3\">\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Terminar\" />\r\n        </div>\r\n    ");
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
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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

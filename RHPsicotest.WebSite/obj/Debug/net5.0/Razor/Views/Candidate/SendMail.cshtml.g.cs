#pragma checksum "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Candidate\SendMail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "414621ed8bfa5bc3a000c4941e6f91bcb2d9efb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidate_SendMail), @"mvc.1.0.view", @"/Views/Candidate/SendMail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"414621ed8bfa5bc3a000c4941e6f91bcb2d9efb1", @"/Views/Candidate/SendMail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58463026d13bcaa327480f71439c8fdaf43f7e4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Candidate_SendMail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CandidateSendVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Candidate\SendMail.cshtml"
  
    ViewData["Title"] = "Enviar Correo";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414621ed8bfa5bc3a000c4941e6f91bcb2d9efb16259", async() => {
                WriteLiteral(@"
    <div class=""row d-flex justify-content-center"">
        <div class=""col-6"">
            <div class=""mb-3"">
                <label for=""exampleFormControlInput1"" class=""form-label h5"">De:</label>
                <input class=""form-control"" type=""text"" value=""Rosa Emilia Hernández Vásquez"" readonly>
            </div>
            <div class=""mb-3"">
                <label for=""exampleFormControlInput1"" class=""form-label h5"">Para:</label>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "414621ed8bfa5bc3a000c4941e6f91bcb2d9efb17005", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 17 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Candidate\SendMail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Candidate\SendMail.cshtml"
                                                                   WriteLiteral(Model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div class=\"mb-3\">\r\n                <label for=\"exampleFormControlInput1\" class=\"form-label h5\">Contraseña:</label>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "414621ed8bfa5bc3a000c4941e6f91bcb2d9efb110043", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 21 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Candidate\SendMail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\WernerMolina\Source\Repos\RHPsicotest\RHPsicotest.WebSite\Views\Candidate\SendMail.cshtml"
                                                                      WriteLiteral(Model.Password);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
            <div class=""mb-3"">
                <label for=""exampleFormControlInput1"" class=""form-label h5"">Asunto:</label>
                <input class=""form-control"" type=""text"" value=""Acceso a Evaluaciones Psicológicas"" readonly>
            </div>
            <div class=""mb-3"">
                <label for=""exampleFormControlTextarea1"" class=""form-label h5"">Contenido:</label>
                <textarea class=""form-control"" rows=""7"" readonly>Estimado(a)
Dando seguimiento al proceso de selección le comparto las evaluaciones psicológicas, de acuerdo al puesto que usted aplica.
El tiempo de duración es aproximadamente 2 horas y solo requiere que las realice en un ambiente cómodo y sin distracciones.</textarea>
            </div>
            <div class=""mb-3"">
                <label for=""exampleFormControlTextarea1"" class=""form-label h5"">Indicaciones Generales:</label>
                <textarea class=""form-control"" rows=""7"" readonly>Ingrese a la siguiente dirección electrónica:
I");
                WriteLiteral(@"ngrese usuario y contraseña.
Lea detenidamente y siga las instrucciones que se le detallarán para el desarrollo de las mismas.
El sistema es sensible a mayúsculas y minúsculas, por lo que recomendamos tener cuidado al momento de registrarse y completar los datos.</textarea>
            </div>
            <div class=""mb-3"">
                <label for=""exampleFormControlTextarea1"" class=""form-label h5"">Contacto:</label>
                <textarea class=""form-control"" rows=""3"" readonly>Rosa Emilia Hernández Vásquez
Rosy.vasquezq@consulightpf.net
7009-7702</textarea>
            </div>
            <div class=""text-center mb-3"">
                <input type=""submit"" class=""btn btn-primary col-6"" value=""Enviar Correo"">
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CandidateSendVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Position\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b3bb37345eec4271de6c231de8a99e021f24aa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Position_Details), @"mvc.1.0.view", @"/Views/Position/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3bb37345eec4271de6c231de8a99e021f24aa4", @"/Views/Position/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d7466d48c5cb4b395b1493544e93aacaa11cf07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Position_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Position>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Position\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row d-flex justify-content-center mt-5"">
    <div class=""col-12 col-sm-10 col-md-8"">
        <h1 class=""fw-bold text-center"">Detalles del Usuario</h1>
        <div class=""d-flex justify-content-center mt-5"">
            <dl class=""row col-12 fs-4"">
                <dt class=""col-sm-6"">
                    ");
#nullable restore
#line 14 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Position\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6 text-center\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Position\Details.cshtml"
               Write(Html.DisplayFor(model => model.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 20 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Position\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.PositionHigher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6 text-center\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Position\Details.cshtml"
               Write(Html.DisplayFor(model => model.PositionHigher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Position\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6 text-center\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Position\Details.cshtml"
               Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Position\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6 text-center\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Position\Details.cshtml"
               Write(Html.DisplayFor(model => model.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div class=\"d-flex justify-content-end mt-5\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3bb37345eec4271de6c231de8a99e021f24aa49280", async() => {
                WriteLiteral("Volver a la Lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span class=\"fs-4 fw-bold\">|</span>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3bb37345eec4271de6c231de8a99e021f24aa410594", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Position\Details.cshtml"
                                   WriteLiteral(Model.IdPosition);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Position> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Shared\_ModalError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1afc73079f31ef93e68205bd7ad1cce96fa72d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ModalError), @"mvc.1.0.view", @"/Views/Shared/_ModalError.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1afc73079f31ef93e68205bd7ad1cce96fa72d2", @"/Views/Shared/_ModalError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"009ee07ee2b96682d536e74a1e08408ea8d628a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ModalError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<String>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .fondo {
        width: 100%;
        height: 100%;
        background-color: rgba(0, 0, 0, .5);
        position: fixed;
        top: 0;
        left: 0;
        z-index: 1000;
    }

</style>

<div class=""fondo d-flex justify-content-center align-items-center"" id=""modal"" onclick=""closeModal()"">
    <div class=""card w-50"">
        <div class=""card-header text-center"">
            <i class=""bi bi-exclamation-square-fill fs-1 text-warning""></i>
        </div>
        <div class=""card-body text-center"">
            <h2 class=""card-title"">Ocurrio un problema !!!</h2>
            <p class=""card-text h5 mb-3"">");
#nullable restore
#line 23 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Shared\_ModalError.cshtml"
                                    Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <button class=\"btn btn-primary\" onclick=\"closeModal()\">Aceptar</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<String> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

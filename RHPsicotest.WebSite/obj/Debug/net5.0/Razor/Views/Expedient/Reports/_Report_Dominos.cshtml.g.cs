#pragma checksum "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Expedient\Reports\_Report_Dominos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5074749061bcfd33f2ed22e43f8ffb511c935659"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expedient_Reports__Report_Dominos), @"mvc.1.0.view", @"/Views/Expedient/Reports/_Report_Dominos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5074749061bcfd33f2ed22e43f8ffb511c935659", @"/Views/Expedient/Reports/_Report_Dominos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"009ee07ee2b96682d536e74a1e08408ea8d628a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Expedient_Reports__Report_Dominos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Result>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Expedient\Reports\_Report_Dominos.cshtml"
  
    Layout = null;

    Result result = Model.ElementAtOrDefault(0);

    int score = result.Score;
    int percentile = result.Percentile;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""text-center fw-bold"">Domino 48</h2>

<div class=""mt-4"">
    <table class=""table-domino table-bordered"">
        <tbody>
            <tr class=""tr-result-domino"">
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr class=""text-center fs-5"">
                <td class=""t-head"">Deficiente</td>
                <td class=""t-head"">Inferior al Término Medio</td>
                <td class=""t-head"">Término Medio</td>
                <td class=""t-head"">Superior al Término Medio</td>
                <td class=""t-head"">Superior</td>
            </tr>
        </tbody>
    </table>
</div>

<div class=""my-4"">
    <p class=""my-2 fs-4 fw-bold"">Puntaje Total: <span class=""fs-4"">");
#nullable restore
#line 35 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Expedient\Reports\_Report_Dominos.cshtml"
                                                              Write(result.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n    <p class=\"my-2 fs-4 fw-bold\">Percentil: <span class=\"fs-4\">");
#nullable restore
#line 36 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Expedient\Reports\_Report_Dominos.cshtml"
                                                          Write(result.Percentile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n</div>\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 1107, "\"", 1115, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <h2 class=\"mb-4 fw-bold\">Interpretación</h2>\r\n    <p class=\"my-4 fs-5 fw-bold\">");
#nullable restore
#line 41 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Expedient\Reports\_Report_Dominos.cshtml"
                            Write(result.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n\r\n<script type=\"text/javascript\">\r\n    let pseudoDomino = document.querySelector(\".tr-result-domino\");\r\n\r\n    let percentileDomino = ");
#nullable restore
#line 48 "C:\Users\WernerMolina\Documents\RHPsicotest\RHPsicotest.WebSite\Views\Expedient\Reports\_Report_Dominos.cshtml"
                      Write(percentile);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    let widthDomino = """";

    if (percentileDomino >= 77) widthDomino = ""90%"";
    if (percentileDomino <= 55) widthDomino = ""70%"";
    if (percentileDomino == 50) widthDomino = ""50%"";
    if (percentileDomino <= 45) widthDomino = ""30%"";
    if (percentileDomino <= 23) widthDomino = ""10%"";


    pseudoDomino.style.setProperty('--width-pseudo', widthDomino);
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Result>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Shared\_HeaderAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea061be1fa18965c0937139598f3bb90fb93c1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderAdmin), @"mvc.1.0.view", @"/Views/Shared/_HeaderAdmin.cshtml")]
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
using RHPsicotest.WebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ea061be1fa18965c0937139598f3bb90fb93c1a", @"/Views/Shared/_HeaderAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bf82189dadf532e8b81a3676c7b9ce74a66dcdd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__HeaderAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form d-flex align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<header id=\"header\" class=\"header fixed-top d-flex align-items-center\">\r\n\r\n    <div class=\"d-flex align-items-center justify-content-between\">\r\n      <a href=\"index.html\" class=\"logo d-flex align-items-center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6ea061be1fa18965c0937139598f3bb90fb93c1a5459", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <span class=\"d-none d-lg-block\">RhPsicotest</span>\r\n      </a>\r\n      <i class=\"bi bi-list toggle-sidebar-btn\"></i>\r\n    </div>\r\n\r\n    <div class=\"search-bar\">\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ea061be1fa18965c0937139598f3bb90fb93c1a6766", async() => {
                WriteLiteral("\r\n        <input type=\"text\" name=\"query\" placeholder=\"Search\" title=\"Enter search keyword\">\r\n        <button type=\"submit\" title=\"Search\"><i class=\"bi bi-search\"></i></button>\r\n      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

    <nav class=""header-nav ms-auto"">
      <ul class=""d-flex align-items-center"">

        <li class=""nav-item d-block d-lg-none"">
          <a class=""nav-link nav-icon search-bar-toggle "" href=""#"">
            <i class=""bi bi-search""></i>
          </a>
        </li>

        <li class=""nav-item dropdown pe-3"">

          <a class=""nav-link nav-profile d-flex align-items-center pe-0"" href=""#"" data-bs-toggle=""dropdown"">
            <img src=""img/profile-img.jpg"" alt=""Profile"" class=""rounded-circle"">
            <span class=""d-none d-md-block dropdown-toggle ps-2"">K. Anderson</span>
          </a>

          <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow profile"">
            <li class=""dropdown-header"">
              <h6>");
#nullable restore
#line 37 "C:\Users\WernerMolina\source\repos\RHPsicotest\RHPsicotest.WebSite\Views\Shared\_HeaderAdmin.cshtml"
             Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
              <span>Web Designer</span>
            </li>
            <li>
              <hr class=""dropdown-divider"">
            </li>

            <li>
              <a class=""dropdown-item d-flex align-items-center"" href=""users-profile.html"">
                <i class=""bi bi-person""></i>
                <span>My Profile</span>
              </a>
            </li>
            <li>
              <hr class=""dropdown-divider"">
            </li>

            <li>
              <a class=""dropdown-item d-flex align-items-center"" href=""users-profile.html"">
                <i class=""bi bi-gear""></i>
                <span>Account Settings</span>
              </a>
            </li>
            <li>
              <hr class=""dropdown-divider"">
            </li>

            <li>
              <a class=""dropdown-item d-flex align-items-center"" href=""pages-faq.html"">
                <i class=""bi bi-question-circle""></i>
                <span>Need Help?</span>
              </a>
    ");
            WriteLiteral(@"        </li>
            <li>
              <hr class=""dropdown-divider"">
            </li>

            <li>
              <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                <i class=""bi bi-box-arrow-right""></i>
                <span>Sign Out</span>
              </a>
            </li>

          </ul>
        </li>

      </ul>
    </nav>

  </header>
");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

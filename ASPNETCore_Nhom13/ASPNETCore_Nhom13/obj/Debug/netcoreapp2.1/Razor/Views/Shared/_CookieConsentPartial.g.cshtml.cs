<<<<<<< HEAD
#pragma checksum "C:\Users\home\Desktop\ASPNETCORE\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\Shared\_CookieConsentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c18f8c7ec540a446e15b225511cfa1a006e3ec3"
=======
#pragma checksum "C:\Users\User\Desktop\ASP\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\Shared\_CookieConsentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c18f8c7ec540a446e15b225511cfa1a006e3ec3"
>>>>>>> 2ef27eff1f4d11fa7085bcf09fc8afaebc76476d
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CookieConsentPartial), @"mvc.1.0.view", @"/Views/Shared/_CookieConsentPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CookieConsentPartial.cshtml", typeof(AspNetCore.Views_Shared__CookieConsentPartial))]
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
<<<<<<< HEAD
#line 1 "C:\Users\home\Desktop\ASPNETCORE\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\User\Desktop\ASP\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\_ViewImports.cshtml"
>>>>>>> 2ef27eff1f4d11fa7085bcf09fc8afaebc76476d
using ASPNETCore_Nhom13;

#line default
#line hidden
<<<<<<< HEAD
#line 2 "C:\Users\home\Desktop\ASPNETCORE\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\User\Desktop\ASP\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\_ViewImports.cshtml"
>>>>>>> 2ef27eff1f4d11fa7085bcf09fc8afaebc76476d
using ASPNETCore_Nhom13.Models;

#line default
#line hidden
<<<<<<< HEAD
#line 1 "C:\Users\home\Desktop\ASPNETCORE\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\Shared\_CookieConsentPartial.cshtml"
=======
#line 1 "C:\Users\User\Desktop\ASP\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\Shared\_CookieConsentPartial.cshtml"
>>>>>>> 2ef27eff1f4d11fa7085bcf09fc8afaebc76476d
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c18f8c7ec540a446e15b225511cfa1a006e3ec3", @"/Views/Shared/_CookieConsentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee8f9c1b69eca1d0e469a85ece921b38e0b8447", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CookieConsentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info navbar-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
<<<<<<< HEAD
#line 3 "C:\Users\home\Desktop\ASPNETCORE\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\Shared\_CookieConsentPartial.cshtml"
=======
#line 3 "C:\Users\User\Desktop\ASP\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\Shared\_CookieConsentPartial.cshtml"
>>>>>>> 2ef27eff1f4d11fa7085bcf09fc8afaebc76476d
  
    var consentFeature = Context.Features.Get<ITrackingConsentFeature>();
    var showBanner = !consentFeature?.CanTrack ?? false;
    var cookieString = consentFeature?.CreateConsentCookie();

#line default
#line hidden
            BeginContext(248, 2, true);
            WriteLiteral("\r\n");
            EndContext();
<<<<<<< HEAD
#line 9 "C:\Users\home\Desktop\ASPNETCORE\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\Shared\_CookieConsentPartial.cshtml"
=======
#line 9 "C:\Users\User\Desktop\ASP\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\Shared\_CookieConsentPartial.cshtml"
>>>>>>> 2ef27eff1f4d11fa7085bcf09fc8afaebc76476d
 if (showBanner)
{

#line default
#line hidden
            BeginContext(271, 963, true);
            WriteLiteral(@"    <nav id=""cookieConsent"" class=""navbar navbar-default navbar-fixed-top"" role=""alert"">
        <div class=""container"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target=""#cookieConsent .navbar-collapse"">
                    <span class=""sr-only"">Toggle cookie consent banner</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                <span class=""navbar-brand""><span class=""glyphicon glyphicon-info-sign"" aria-hidden=""true""></span></span>
            </div>
            <div class=""collapse navbar-collapse"">
                <p class=""navbar-text"">
                    Use this space to summarize your privacy and cookie use policy.
                </p>
                <div class=""navbar-right"">
                    ");
            EndContext();
            BeginContext(1234, 92, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d824df008864596b8a298548407c3a4", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82b3d146dd28411db0a9e23471439c9c", async() => {
>>>>>>> 2ef27eff1f4d11fa7085bcf09fc8afaebc76476d
                BeginContext(1312, 10, true);
                WriteLiteral("Learn More");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1326, 99, true);
            WriteLiteral("\r\n                    <button type=\"button\" class=\"btn btn-default navbar-btn\" data-cookie-string=\"");
            EndContext();
            BeginContext(1426, 12, false);
<<<<<<< HEAD
#line 28 "C:\Users\home\Desktop\ASPNETCORE\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\Shared\_CookieConsentPartial.cshtml"
=======
#line 28 "C:\Users\User\Desktop\ASP\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\Shared\_CookieConsentPartial.cshtml"
>>>>>>> 2ef27eff1f4d11fa7085bcf09fc8afaebc76476d
                                                                                            Write(cookieString);

#line default
#line hidden
            EndContext();
            BeginContext(1438, 456, true);
            WriteLiteral(@""">Accept</button>
                </div>
            </div>
        </div>
    </nav>
    <script>
        (function () {
            document.querySelector(""#cookieConsent button[data-cookie-string]"").addEventListener(""click"", function (el) {
                document.cookie = el.target.dataset.cookieString;
                document.querySelector(""#cookieConsent"").classList.add(""hidden"");
            }, false);
        })();
    </script>
");
            EndContext();
<<<<<<< HEAD
#line 41 "C:\Users\home\Desktop\ASPNETCORE\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\Shared\_CookieConsentPartial.cshtml"
=======
#line 41 "C:\Users\User\Desktop\ASP\ASPNETCore_Nhom13\ASPNETCore_Nhom13\Views\Shared\_CookieConsentPartial.cshtml"
>>>>>>> 2ef27eff1f4d11fa7085bcf09fc8afaebc76476d
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\_FooterPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9498577bfe10a14f12c0962bbe565afa23b672e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterPartialView), @"mvc.1.0.view", @"/Views/Shared/_FooterPartialView.cshtml")]
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
#line 1 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\_ViewImports.cshtml"
using WEBBANTBDTK;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\_ViewImports.cshtml"
using WEBBANTBDTK.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9498577bfe10a14f12c0962bbe565afa23b672e9", @"/Views/Shared/_FooterPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7c1db7c694871d8bf94376b1441f0ac91aab41c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__FooterPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/logo/Logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""footer-area"">
    <div class=""footer-top section-space-y-axis-100 text-black"" data-bg-color=""#e5ddcc"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 col-md-6"">
                    <div class=""widget-item"">
                        <div class=""footer-logo pb-4"">
                            <a href=""/"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9498577bfe10a14f12c0962bbe565afa23b672e94282", async() => {
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
            WriteLiteral(@"
                            </a>
                        </div>
                        <p class=""short-desc mb-2"">CÔNG TY KINH DOANH THIẾT BỊ ĐIỆN TỬ</p>
                        <div class=""widget-contact-info pb-6"">
                            <ul>
                                <li>
                                    <i class=""pe-7s-map-marker""></i>
                                    359/59 Bình An, Cần Giờ TPHCM
                                </li>
                                <li>
                                    <i class=""fa fa-mobile""></i>
                                    <a href=""tel:0396651974"">039.665.1974</a>
                                </li>
                                <li>
                                    <i class=""pe-7s-mail""></i>
                                    <a href=""mailto://kybk9a6@gmail.com"">kybk9a6@gmail.com</a>
                                </li>
                            </ul>
                        </div>
                        <div class=""payment-me");
            WriteLiteral(@"thod"">
                            <a href=""javascript:void(0)"">
                                <img src=""/assets/images/payment/2.png"" alt=""Payment Method"">
                            </a>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-2 offset-lg-1 col-md-6 pt-10 pt-lg-0"">
                    <div class=""widget-item"">
                        <h3 class=""widget-title mb-5"">Thông tin</h3>
                        <ul class=""widget-list-item"">
                            <li>
                                <a href=""javascript:void(0)"">FAQ</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Shipping</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Returns</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0");
            WriteLiteral(@")"">Order Status</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Gift Card Balance</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Accessibility</a>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-2 offset-lg-1 col-md-6 pt-10 pt-lg-0"">
                    <div class=""widget-item"">
                        <h3 class=""widget-title mb-5"">Tài khoản của tôi</h3>
                        <ul class=""widget-list-item"">
                            <li>
                                <a href=""javascript:void(0)"">My Account</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Checkout</a>
                            </li>
                            <li>
                          ");
            WriteLiteral(@"      <a href=""javascript:void(0)"">Validation</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Wishlist</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Terms of Use</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">FAQ</a>
                            </li>
                        </ul>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <div class=""footer-bottom py-3"" data-bg-color=""#0000FF"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""copyright"">
                        <span class=""copyright-text text-white"">© Shop mua bán thiết bị điện tử <i class=""fa fa-heart text-danger""></i> - Lý Kỳ || Thuận Lợi || Ngọc Sơn  </span>
       ");
            WriteLiteral("             </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
#pragma checksum "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecca9a5f897e4063b77b338d394662ee12d6e005"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeaderCart_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HeaderCart/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecca9a5f897e4063b77b338d394662ee12d6e005", @"/Views/Shared/Components/HeaderCart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7c1db7c694871d8bf94376b1441f0ac91aab41c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_HeaderCart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WEBBANTBDTK.ModelViews.CartItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
 if (Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""harmic-offcanvas-body"">
        <div class=""minicart-content"">
            <div class=""minicart-heading"">
                <h4 class=""mb-0"">Giỏ hàng</h4>
                <a href=""#"" class=""button-close""><i class=""pe-7s-close""></i></a>
            </div>
            <ul class=""minicart-list"">
");
#nullable restore
#line 11 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
                 foreach (var item in Model)
                {
                    string url = $"/{item.product.Alias}-{item.product.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"minicart-product\">\n                        <a");
            BeginWriteAttribute("href", " href=\"", 624, "\"", 635, 1);
#nullable restore
#line 15 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 631, url, 631, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-item_img\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ecca9a5f897e4063b77b338d394662ee12d6e0054968", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 718, "~/images/products/", 718, 18, true);
#nullable restore
#line 16 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
AddHtmlAttributeValue("", 736, item.product.Thumb, 736, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
AddHtmlAttributeValue("", 762, item.product.ProductName, 762, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </a>\n                        <div class=\"product-item_content\">\n                            <a class=\"product-item_title\"");
            BeginWriteAttribute("href", " href=\"", 935, "\"", 946, 1);
#nullable restore
#line 19 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 942, url, 942, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                                 Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                            <span class=\"product-item_quantity\">");
#nullable restore
#line 20 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                           Write(item.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 20 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                                          Write(item.product.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\n                        </div>\n                    </li>\n");
#nullable restore
#line 23 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n        </div>\n        <div class=\"minicart-item_total\">\n            <span>Tổng tiền</span>\n            <span class=\"ammount\">");
#nullable restore
#line 28 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
                             Write(Model.Sum(x => x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\n        </div>\n        <div class=\"group-btn_wrap d-grid gap-2\">\n            <a style=\"background-color: #0000FF;\" href=\"cart.html\" class=\"btn btn-secondary btn-primary-hover\">Xem giỏ hàng</a>\n");
#nullable restore
#line 32 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a style=\"background-color: #0000FF;\" href=\"/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Thanh toán</a>\n");
#nullable restore
#line 35 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a style =\"background-color: #0000FF;\" href=\"/dang-nhap.html?returnUrl=/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Thanh toán</a>\n");
#nullable restore
#line 39 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n");
#nullable restore
#line 42 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <div class=\"harmic-offcanvas-body\">\n        <div class=\"minicart-content\">\n            <div class=\"minicart-heading\">\n                <h4 class=\"mb-0\">Giỏ hàng rỗng</h4>\n            </div>\n        </div>\n   </div>\n");
#nullable restore
#line 52 "D:\DOANCOSO2\WEBBANTBDTK\WEBBANTBDTK\Views\Shared\Components\HeaderCart\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WEBBANTBDTK.ModelViews.CartItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Studies\DH18CT\Hoc Ky 7\Web 2\Final Project\SportStores\SportStores\SportStores\Views\Shared\ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f61f46ff554f89bc87bbd477453fad930d27ae6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductSummary), @"mvc.1.0.view", @"/Views/Shared/ProductSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ProductSummary.cshtml", typeof(AspNetCore.Views_Shared_ProductSummary))]
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
#line 1 "D:\Studies\DH18CT\Hoc Ky 7\Web 2\Final Project\SportStores\SportStores\SportStores\Views\_ViewImports.cshtml"
using SportStores.Models;

#line default
#line hidden
#line 3 "D:\Studies\DH18CT\Hoc Ky 7\Web 2\Final Project\SportStores\SportStores\SportStores\Views\_ViewImports.cshtml"
using SportStores.Models.ViewModels;

#line default
#line hidden
#line 5 "D:\Studies\DH18CT\Hoc Ky 7\Web 2\Final Project\SportStores\SportStores\SportStores\Views\_ViewImports.cshtml"
using SportStores.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f61f46ff554f89bc87bbd477453fad930d27ae6f", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312acae3cc868f7d7c57dbf9726db404ae04cf39", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(44, 100, true);
            WriteLiteral("\r\n        <div class=\"container\">\r\n            <div class=\"wrapper\">\r\n                <a href=\"#\">\r\n");
            EndContext();
            BeginContext(300, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(320, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ddb31114f1047da8674565e2ef6a402", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 330, "~/assets/images/", 330, 16, true);
#line 9 "D:\Studies\DH18CT\Hoc Ky 7\Web 2\Final Project\SportStores\SportStores\SportStores\Views\Shared\ProductSummary.cshtml"
AddHtmlAttributeValue("", 346, Model.Image, 346, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(361, 81, true);
            WriteLiteral("\r\n                </a>\r\n                <div class=\"title\">\r\n                    ");
            EndContext();
            BeginContext(443, 10, false);
#line 12 "D:\Studies\DH18CT\Hoc Ky 7\Web 2\Final Project\SportStores\SportStores\SportStores\Views\Shared\ProductSummary.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(453, 219, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"place\">\r\n                    Surkhet, Nepal\r\n                </div>\r\n            </div>\r\n            <div class=\"content\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(673, 17, false);
#line 20 "D:\Studies\DH18CT\Hoc Ky 7\Web 2\Final Project\SportStores\SportStores\SportStores\Views\Shared\ProductSummary.cshtml"
               Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(690, 40, true);
            WriteLiteral("\r\n                </p>\r\n                ");
            EndContext();
            BeginContext(730, 724, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a1e59c8cd6d4100886314fda51d4a85", async() => {
                BeginContext(840, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(862, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "71c318874ecb4b948876c1582d6fa629", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 24 "D:\Studies\DH18CT\Hoc Ky 7\Web 2\Final Project\SportStores\SportStores\SportStores\Views\Shared\ProductSummary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(903, 59, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"returnUrl\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                           value=\"", 962, "\"", 1045, 1);
#line 26 "D:\Studies\DH18CT\Hoc Ky 7\Web 2\Final Project\SportStores\SportStores\SportStores\Views\Shared\ProductSummary.cshtml"
WriteAttributeValue("", 998, ViewContext.HttpContext.Request.PathAndQuery(), 998, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1046, 141, true);
                WriteLiteral(" />\r\n                    <div class=\"buttons\">\r\n                        <div class=\"btn\">\r\n                            <button type=\"button\">");
                EndContext();
                BeginContext(1188, 25, false);
#line 29 "D:\Studies\DH18CT\Hoc Ky 7\Web 2\Final Project\SportStores\SportStores\SportStores\Views\Shared\ProductSummary.cshtml"
                                             Write(Model.Price.ToString("c"));

#line default
#line hidden
                EndContext();
                BeginContext(1213, 234, true);
                WriteLiteral("</button>\r\n                        </div>\r\n                        <div class=\"btn\">\r\n                            <button type=\"submit\">Add to card</button>\r\n                        </div>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "D:\Studies\DH18CT\Hoc Ky 7\Web 2\Final Project\SportStores\SportStores\SportStores\Views\Shared\ProductSummary.cshtml"
AddHtmlAttributeValue("", 740, Model.ProductID, 740, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1454, 626, true);
            WriteLiteral(@"
            </div>
            <div class=""icons"">
                <li><a href=""#""><span class=""fab fa-facebook-f""></span></a></li>
                <li><a href=""#""><span class=""fab fa-twitter""></span></a></li>
                <li><a href=""#""><span class=""fab fa-instagram""></span></a></li>
            </div>
        </div>
    


<script>
        const img = document.querySelector(""img"");
        const icons = document.querySelector("".icons"");
        img.onclick = function () {
            this.classList.toggle(""active"");
            icons.classList.toggle(""active"");
        }
</script>






");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591

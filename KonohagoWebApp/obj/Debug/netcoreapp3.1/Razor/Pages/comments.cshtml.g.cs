#pragma checksum "A:\HTML\ArtOfWorld\KonohagoWebApp\Pages\comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c46fc32fcf6ff0339283570bce08ef87abc7c2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KonohagoWebApp.Pages.Pages_comments), @"mvc.1.0.razor-page", @"/Pages/comments.cshtml")]
namespace KonohagoWebApp.Pages
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
#line 1 "A:\HTML\ArtOfWorld\KonohagoWebApp\Pages\_ViewImports.cshtml"
using KonohagoWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "A:\HTML\ArtOfWorld\KonohagoWebApp\Pages\comments.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c46fc32fcf6ff0339283570bce08ef87abc7c2c", @"/Pages/comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5677f98e61f3f07d3913f1bdc6dcd37fddbcb129", @"/Pages/_ViewImports.cshtml")]
    public class Pages_comments : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("введите ваш комментарий"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("message-3b9a"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("u-border-2 u-border-black u-border-no-left u-border-no-right u-border-no-top u-input u-input-rectangle u-input-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("required", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("u-clearfix u-form-spacing-24 u-form-vertical u-inner-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding: 24px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("source", new global::Microsoft.AspNetCore.Html.HtmlString("email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("u-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html style=\"font-size: 16px;\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c46fc32fcf6ff0339283570bce08ef87abc7c2c8427", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"keywords\" content=\"Амирхан\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 327, "\"", 337, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""page_type"" content=""np-template-header-footer-from-plugin"">
    <title>Коммет + тайтлы</title>
    <link rel=""stylesheet"" href=""/css/nicepage.css"" media=""screen"">
    <link rel=""stylesheet"" href=""/css/Коммет+-тайтлы.css"" media=""screen"">
    <script class=""u-script"" type=""text/javascript"" src=""jquery-1.9.1.min.js""");
                BeginWriteAttribute("defer", " defer=\"", 675, "\"", 683, 0);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script class=\"u-script\" type=\"text/javascript\" src=\"nicepage.js\"");
                BeginWriteAttribute("defer", " defer=\"", 765, "\"", 773, 0);
                EndWriteAttribute();
                WriteLiteral(@"></script>
    <meta name=""generator"" content=""Nicepage 3.0.13, nicepage.com"">
    <link id=""u-theme-google-font"" rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Montserrat:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i|Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i"">

    <meta property=""og:title"" content=""Коммет + тайтлы"">
    <meta property=""og:type"" content=""website"">
    <meta name=""theme-color"" content=""#478ac9"">
    <link rel=""canonical"" href=""index.html"">
    <meta property=""og:url"" content=""index.html"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c46fc32fcf6ff0339283570bce08ef87abc7c2c11113", async() => {
                WriteLiteral(@"
    <header class=""u-align-left u-clearfix u-header u-header"" id=""sec-e27a""><div class=""u-clearfix u-sheet u-sheet-1""></div></header>
    <div class=""u-clearfix u-layout-wrap u-layout-wrap-1"">
        <div class=""u-gutter-0 u-layout"">
            <div class=""u-layout-row"">
                <div class=""u-align-left u-container-style u-layout-cell u-right-cell u-size-60 u-white u-layout-cell-1"">
                    <div class=""u-container-layout u-container-layout-1"">
                        <div class=""u-form u-form-1"">
");
#nullable restore
#line 36 "A:\HTML\ArtOfWorld\KonohagoWebApp\Pages\comments.cshtml"
                             if (HttpContext.Session.GetString("role") != "Guest")
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c46fc32fcf6ff0339283570bce08ef87abc7c2c12239", async() => {
                    WriteLiteral(@"
                                    <input type=""hidden"" id=""siteId"" name=""siteId"" value=""165207"">
                                    <input type=""hidden"" id=""pageId"" name=""pageId"" value=""165209"">
                                    <div class=""u-form-group u-form-message u-form-group-1"">
                                        <label for=""message-3b9a"" class=""u-form-control-hidden u-label"">Message</label>
                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c46fc32fcf6ff0339283570bce08ef87abc7c2c12982", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 43 "A:\HTML\ArtOfWorld\KonohagoWebApp\Pages\comments.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Comment.Text);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c46fc32fcf6ff0339283570bce08ef87abc7c2c15116", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 44 "A:\HTML\ArtOfWorld\KonohagoWebApp\Pages\comments.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Comment.Text);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                    </div>
                                    <div class=""u-align-left u-form-group u-form-submit u-form-group-2"">
                                        <button type=""submit"" class=""u-black u-btn u-btn-round u-btn-submit u-button-style u-hover-grey-60 u-radius-50 u-btn-1"">
                                            ДОБАВИТЬ<br>
                                        </button>
                                        <input type=""submit"" value=""submit"" class=""u-form-control-hidden"">
                                    </div>
                                    <div class=""u-form-send-message u-form-send-success""> Thank you! Your message has been sent. </div>
                                    <div class=""u-form-send-error u-form-send-message""> Unable to send your message. Please fix errors then try again. </div>
                                    <input type=""hidden""");
                    BeginWriteAttribute("value", " value=\"", 3959, "\"", 3967, 0);
                    EndWriteAttribute();
                    WriteLiteral(" name=\"recaptchaResponse\">\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 56 "A:\HTML\ArtOfWorld\KonohagoWebApp\Pages\comments.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <section class=\"u-clearfix u-white u-section-1\" id=\"sec-8679\">\r\n        <div class=\"u-clearfix u-sheet u-sheet-1\">\r\n");
#nullable restore
#line 65 "A:\HTML\ArtOfWorld\KonohagoWebApp\Pages\comments.cshtml"
             if (Model.comments.Count > 0) ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "A:\HTML\ArtOfWorld\KonohagoWebApp\Pages\comments.cshtml"
             foreach (var comment in Model.comments)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""u-clearfix u-gutter-0 u-layout-wrap u-layout-wrap-1"">
                <div class=""u-layout"">
                    <div class=""u-layout-row"">
                        <div class=""u-align-left u-container-style u-layout-cell u-right-cell u-size-37 u-layout-cell-2"">
                            <div class=""u-container-layout u-container-layout-2"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 4842, "\"", 4877, 2);
                WriteAttributeValue("", 4849, "/Profile?id=", 4849, 12, true);
#nullable restore
#line 73 "A:\HTML\ArtOfWorld\KonohagoWebApp\Pages\comments.cshtml"
WriteAttributeValue("", 4861, comment.User_id, 4861, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <h2 class=\"u-text u-text-1\">");
#nullable restore
#line 73 "A:\HTML\ArtOfWorld\KonohagoWebApp\Pages\comments.cshtml"
                                                                                               Write(comment.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2></a>\r\n                                    <br>");
#nullable restore
#line 74 "A:\HTML\ArtOfWorld\KonohagoWebApp\Pages\comments.cshtml"
                                   Write(comment.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 80 "A:\HTML\ArtOfWorld\KonohagoWebApp\Pages\comments.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </section>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KonohagoWebApp.Pages.commentsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KonohagoWebApp.Pages.commentsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KonohagoWebApp.Pages.commentsModel>)PageContext?.ViewData;
        public KonohagoWebApp.Pages.commentsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

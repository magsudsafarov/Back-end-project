#pragma checksum "C:\Users\Lenovo\Desktop\Project\Project\Views\ContactUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "810841df29a69b96eafd0d5c8e976f2b9574ba2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactUs_Index), @"mvc.1.0.view", @"/Views/ContactUs/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"810841df29a69b96eafd0d5c8e976f2b9574ba2a", @"/Views/ContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_ContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://whizthemes.com/mail-php/genger/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\Project\Project\Views\ContactUs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- breadcrumb area start -->
<div class=""breadcrumb-area bg-img"" data-bg=""~/assets/img/banner/breadcrumb-banner.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""breadcrumb-wrap text-center"">
                    <nav aria-label=""breadcrumb"">
                        <h1 class=""breadcrumb-title"">Contact Us</h1>
                        <ul class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Contact Us</li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- breadcrumb area end -->
<!-- contact wrapper area start -->
<div class=""contact-area section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""contact-message"">
");
            WriteLiteral("                    <h2 class=\"contact-title\">tell us your project</h2>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "810841df29a69b96eafd0d5c8e976f2b9574ba2a5647", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-lg-6 col-md-6 col-sm-6"">
                                <input name=""first_name"" placeholder=""Name *"" type=""text"" required>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6"">
                                <input name=""phone"" placeholder=""Phone *"" type=""text"" required>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6"">
                                <input name=""email_address"" placeholder=""Email *"" type=""text"" required>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6"">
                                <input name=""contact_subject"" placeholder=""Subject *"" type=""text"">
                            </div>
                            <div class=""col-12"">
                                <div class=""contact2-textarea text-center"">
                         ");
                WriteLiteral("           <textarea placeholder=\"Message *\" name=\"message\" class=\"form-control2\"");
                BeginWriteAttribute("required", " required=\"", 2380, "\"", 2391, 0);
                EndWriteAttribute();
                WriteLiteral(@"></textarea>
                                </div>
                                <div class=""contact-btn"">
                                    <button class=""btn"" type=""submit"">Send Message</button>
                                </div>
                            </div>
                            <div class=""col-12 d-flex justify-content-center"">
                                <p class=""form-messege""></p>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""contact-info pt-0"">
                    <h2 class=""contact-title"">contact us</h2>
                    <p>
                        Claritas est etiam processus dynamicus, qui sequitur mutationem consuetudium lectorum. Mirum
                        est notare quam littera gothica, quam nunc putamus parum claram anteposuerit litterarum
                        formas human.
                    </p>
                    <ul>
                        <li><i class=""fa fa-fax""></i> Address : No 40 Baria Sreet 133/2 NewYork City</li>
                        <li><i class=""fa fa-phone""></i> info@yourdomain.com</li>
                        <li><i class=""fa fa-envelope-o""></i> +88013245657</li>
                    </ul>
                    <div class=""working-time"">
                        <h3>Working Hours</h3>
                        <p class=""pb-0""><span>Monday – Saturday:</span>08AM – 22PM</p>
   ");
            WriteLiteral("                 </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- contact wrapper area end -->\r\n");
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

#pragma checksum "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93706d69fd77769ef58631f66c714adbd9cde230"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/_ViewImports.cshtml"
using DependencyInjection.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93706d69fd77769ef58631f66c714adbd9cde230", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dac13b05dac5fd34da371da2bc3e72ee4f0151b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-href-include", "lib/bootstrap/dist/css/*.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-1 p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 2 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
       Layout = null; 

#line default
#line hidden
            BeginContext(52, 41, true);
            WriteLiteral("     \n    <!DOCTYPE html>\n    <html>\n    ");
            EndContext();
            BeginContext(93, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93706d69fd77769ef58631f66c714adbd9cde2304693", async() => {
                BeginContext(99, 115, true);
                WriteLiteral("\n        <meta name=\"viewport\" content=\"width=device-width\" />\n        <title>Dependency Injection</title>\n        ");
                EndContext();
                BeginContext(214, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "93706d69fd77769ef58631f66c714adbd9cde2305188", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.HrefInclude = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(291, 5, true);
                WriteLiteral("\n    ");
                EndContext();
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
            EndContext();
            BeginContext(303, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(308, 1027, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93706d69fd77769ef58631f66c714adbd9cde2307367", async() => {
                BeginContext(330, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 12 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
         if (ViewData.Count > 0)
        {

#line default
#line hidden
                BeginContext(374, 72, true);
                WriteLiteral("            <table class=\"table table-bordered table-sm table-striped\">\n");
                EndContext();
#line 15 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
                 foreach (var kvp in ViewData)
                {

#line default
#line hidden
                BeginContext(511, 28, true);
                WriteLiteral("                    <tr><td>");
                EndContext();
                BeginContext(540, 7, false);
#line 17 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
                       Write(kvp.Key);

#line default
#line hidden
                EndContext();
                BeginContext(547, 9, true);
                WriteLiteral("</td><td>");
                EndContext();
                BeginContext(557, 9, false);
#line 17 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
                                        Write(kvp.Value);

#line default
#line hidden
                EndContext();
                BeginContext(566, 11, true);
                WriteLiteral("</td></tr>\n");
                EndContext();
#line 18 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
                }

#line default
#line hidden
                BeginContext(595, 21, true);
                WriteLiteral("            </table>\n");
                EndContext();
#line 20 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
        }

#line default
#line hidden
                BeginContext(626, 182, true);
                WriteLiteral("        <table class=\"table table-bordered table-sm table-striped\">\n            <thead>\n                <tr><th>Name</th><th>Price</th></tr>\n            </thead>\n            <tbody>\n");
                EndContext();
#line 26 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
                 if (Model == null)
                {

#line default
#line hidden
                BeginContext(862, 84, true);
                WriteLiteral("                    <tr><td colspan=\"3\" class=\"text-center\">No Model Data</td></tr>\n");
                EndContext();
#line 29 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#line 32 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
                     foreach (var p in Model)
                    {

#line default
#line hidden
                BeginContext(1071, 61, true);
                WriteLiteral("                        <tr>\n                            <td>");
                EndContext();
                BeginContext(1133, 6, false);
#line 35 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
                           Write(p.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1139, 38, true);
                WriteLiteral("</td>\n                            <td>");
                EndContext();
                BeginContext(1178, 32, false);
#line 36 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
                           Write(string.Format("{0:C2}", p.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1210, 36, true);
                WriteLiteral("</td>\n                        </tr>\n");
                EndContext();
#line 38 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
                    }

#line default
#line hidden
#line 38 "/Users/dalebard/Desktop/Projects/DependencyInjection/DependencyInjection/DependencyInjection/Views/Home/Index.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(1286, 42, true);
                WriteLiteral("            </tbody>\n        </table>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1335, 12, true);
            WriteLiteral("\n    </html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
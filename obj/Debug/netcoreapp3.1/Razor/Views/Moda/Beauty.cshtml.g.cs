#pragma checksum "C:\Users\HP\Desktop\Ödev\WebApplication1\Views\Moda\Beauty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80eaa364533dd561c47b5c05b6450e682db10807"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Moda_Beauty), @"mvc.1.0.view", @"/Views/Moda/Beauty.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80eaa364533dd561c47b5c05b6450e682db10807", @"/Views/Moda/Beauty.cshtml")]
    public class Views_Moda_Beauty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApplication1.Model.Moda>>
    {
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
#line 2 "C:\Users\HP\Desktop\Ödev\WebApplication1\Views\Moda\Beauty.cshtml"
  
    ViewData["Title"] = "Beauty";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <ul>\r\n");
#nullable restore
#line 9 "C:\Users\HP\Desktop\Ödev\WebApplication1\Views\Moda\Beauty.cshtml"
          
            foreach (var m in Model)
            {
                if (m.Type.Id == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\"  style=\"background: #fff\">\r\n                        <li class=\"w3-button\" style=\"margin-top: 10px; height: 200%; width: 95%;margin-right: 50%\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80eaa364533dd561c47b5c05b6450e682db108073343", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 485, "~/Resim/", 485, 8, true);
#nullable restore
#line 16 "C:\Users\HP\Desktop\Ödev\WebApplication1\Views\Moda\Beauty.cshtml"
AddHtmlAttributeValue("", 493, m.Image.Name, 493, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 7, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 515, "height:", 515, 7, true);
#nullable restore
#line 16 "C:\Users\HP\Desktop\Ödev\WebApplication1\Views\Moda\Beauty.cshtml"
AddHtmlAttributeValue(" ", 522, m.Image.Height, 523, 15, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 538, "%;", 538, 2, true);
            AddHtmlAttributeValue(" ", 540, "width:", 541, 7, true);
#nullable restore
#line 16 "C:\Users\HP\Desktop\Ödev\WebApplication1\Views\Moda\Beauty.cshtml"
AddHtmlAttributeValue(" ", 547, m.Image.Width, 548, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 562, "%;float:", 562, 8, true);
            AddHtmlAttributeValue(" ", 570, "left", 571, 5, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <h1 style=\"font-size: 32px;text-align: center;font-weight: 600;font-family: \'Text Me One\', sans-serif;\">");
#nullable restore
#line 17 "C:\Users\HP\Desktop\Ödev\WebApplication1\Views\Moda\Beauty.cshtml"
                                                                                                                               Write(m.ModaTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <h6><b>");
#nullable restore
#line 18 "C:\Users\HP\Desktop\Ödev\WebApplication1\Views\Moda\Beauty.cshtml"
                              Write(m.Type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h6>\r\n                            <pre>");
#nullable restore
#line 19 "C:\Users\HP\Desktop\Ödev\WebApplication1\Views\Moda\Beauty.cshtml"
                            Write(m.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n                    \r\n                        </li></a>\r\n");
#nullable restore
#line 22 "C:\Users\HP\Desktop\Ödev\WebApplication1\Views\Moda\Beauty.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApplication1.Model.Moda>> Html { get; private set; }
    }
}
#pragma warning restore 1591

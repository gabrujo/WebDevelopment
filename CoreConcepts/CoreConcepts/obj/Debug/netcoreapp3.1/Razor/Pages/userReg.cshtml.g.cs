#pragma checksum "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\userReg.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c315c7d06ecedd54bb999da0b37bcc522dd5265"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreConcepts.Pages.Pages_userReg), @"mvc.1.0.razor-page", @"/Pages/userReg.cshtml")]
namespace CoreConcepts.Pages
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
#line 1 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\_ViewImports.cshtml"
using CoreConcepts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c315c7d06ecedd54bb999da0b37bcc522dd5265", @"/Pages/userReg.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da6d87fce9d77df3bdbfa113ddf9dedda6eb4bc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_userReg : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("f1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/SimpleReceiveForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\userReg.cshtml"
  
    ViewData["Title"] = "UserReg";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>User Reg - Without a server side class</h1>\r\n<ul>\r\n    <li>Every Razor page starts with ");
            WriteLiteral(@"@page (two at signs means a single at sign)</li>
    <li>The second line could be the page model class</li>
    <li>The page has to have a cshtml extension</li>
    <li>
        server side code can be embedded in the page using Razor syntax (C# code in the
        cshtml page is referred to as Razor)
    </li>
</ul>
<hr />
<div class=""container"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c315c7d06ecedd54bb999da0b37bcc522dd52655219", async() => {
                WriteLiteral(@"
        <div class=""form-group row"">
            <label for=""txtNM"" class=""col-md-2"">Name</label>
            <input type=""text"" class=""form-control col-md-3"" name=""txtNM"" id=""txtNM"" />
        </div>
        <div class=""form-group row"">
            <label for=""txtEmail"" class=""col-md-2"">Email</label>
            <input type=""text"" class=""form-control col-md-3"" name=""txtEmail""
                   id=""txtEmail"" />
        </div>
        <button type=""submit"" class=""btn btn-success offset-md-2"">Submit</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\userReg.cshtml"
      
        string name = String.Empty;
        string email = String.Empty;
        if (Request.HasFormContentType)
        {
            name = Request.Form["txtNM"];
            email = Request.Form["txtEmail"];
            ViewData["NMEMAIL"] = name + " : " + email;
        }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\userReg.cshtml"
      
        if ((name != String.Empty) || (email != String.Empty))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("Name Entered = ");
#nullable restore
#line 43 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\userReg.cshtml"
                        Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Email Entered=");
#nullable restore
#line 43 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\userReg.cshtml"
                                            Write(email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\userReg.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"d1\">\r\n        ");
#nullable restore
#line 47 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\userReg.cshtml"
   Write(ViewData["NMEMAIL"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_userReg> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_userReg> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_userReg>)PageContext?.ViewData;
        public Pages_userReg Model => ViewData.Model;
    }
}
#pragma warning restore 1591

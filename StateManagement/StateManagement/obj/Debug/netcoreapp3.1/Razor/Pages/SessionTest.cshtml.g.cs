#pragma checksum "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\StateManagement\StateManagement\Pages\SessionTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74eab1437955d11bc98b1927c67ce37944e34ba0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StateManagement.Pages.Pages_SessionTest), @"mvc.1.0.razor-page", @"/Pages/SessionTest.cshtml")]
namespace StateManagement.Pages
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
#line 1 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\StateManagement\StateManagement\Pages\_ViewImports.cshtml"
using StateManagement;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eab1437955d11bc98b1927c67ce37944e34ba0", @"/Pages/SessionTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"691cc7629982491fcebe0b4c5e462bb7657f13e1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SessionTest : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\StateManagement\StateManagement\Pages\SessionTest.cshtml"
  
    ViewData["Title"] = "SessionTest";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Session Test</h1>\r\n<div>");
#nullable restore
#line 7 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\StateManagement\StateManagement\Pages\SessionTest.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StateManagement.Pages.SessionTestModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StateManagement.Pages.SessionTestModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StateManagement.Pages.SessionTestModel>)PageContext?.ViewData;
        public StateManagement.Pages.SessionTestModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\Models\MyPartials\_MyPortfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8b56e88047cf08451842abedb9c0cd22e9bd64c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreConcepts.Pages.Models.MyPartials.Pages_Models_MyPartials__MyPortfolio), @"mvc.1.0.view", @"/Pages/Models/MyPartials/_MyPortfolio.cshtml")]
namespace CoreConcepts.Pages.Models.MyPartials
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8b56e88047cf08451842abedb9c0cd22e9bd64c", @"/Pages/Models/MyPartials/_MyPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdd0be5830c4ea806704954ab6aaae9891fb6eda", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Models_MyPartials__MyPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Models.StockInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\Models\MyPartials\_MyPortfolio.cshtml"
  
    var m = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <tr>\r\n        <th>Stock</th>\r\n        <th>Price</th>\r\n    </tr>\r\n");
#nullable restore
#line 12 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\Models\MyPartials\_MyPortfolio.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr><td>");
#nullable restore
#line 14 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\Models\MyPartials\_MyPortfolio.cshtml"
           Write(item.Symbol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 14 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\Models\MyPartials\_MyPortfolio.cshtml"
                                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 15 "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\Models\MyPartials\_MyPortfolio.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr></tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Models.StockInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591

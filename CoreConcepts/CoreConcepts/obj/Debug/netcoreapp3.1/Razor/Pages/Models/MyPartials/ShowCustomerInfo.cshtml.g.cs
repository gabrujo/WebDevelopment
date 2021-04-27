#pragma checksum "C:\Users\gabru\OneDrive\Área de Trabalho\Coding\WebDevelopment\CoreConcepts\CoreConcepts\Pages\Models\MyPartials\ShowCustomerInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1f2bf0bd56c9da9a010f1cf8352ef45bfaf0f24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreConcepts.Pages.Models.MyPartials.Pages_Models_MyPartials_ShowCustomerInfo), @"mvc.1.0.view", @"/Pages/Models/MyPartials/ShowCustomerInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f2bf0bd56c9da9a010f1cf8352ef45bfaf0f24", @"/Pages/Models/MyPartials/ShowCustomerInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdd0be5830c4ea806704954ab6aaae9891fb6eda", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Models_MyPartials_ShowCustomerInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    public class ShowCustomerInfoModel : PageModel
    {
        public CustomerInfo CInfo { get; set; }
        public void OnGet()
        {
            // get customer info from DB
            CInfo = new CustomerInfo();
            CInfo.FirstName = ""Bill"";
            CInfo.LastName = ""Baker"";
            CInfo.Email = ""bill@yahoo.com"";
            // check DB and get the stock prices for stocks in the portfolio
            CInfo.STList = new List<StockInfo>();
            StockInfo s1 = new StockInfo { Symbol = ""IBM"", Price = 143.45 };
            CInfo.STList.Add(s1);
            StockInfo s2 = new StockInfo { Symbol = ""AAPL"", Price = 195.75 };
            CInfo.STList.Add(s2);
        }
    }");
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

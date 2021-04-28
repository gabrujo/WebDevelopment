using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StateManagement.Models;
using StateManagement.Utils;

namespace StateManagement.Pages
{
    public class ShowProductOnSaleModel : PageModel
    {
        public Product Prod { get; set; }
        public void OnGet()
        {
            //Prod = SessionFacade.PROD;
            Prod = CookieFacade.PROD;
        }
    }
}

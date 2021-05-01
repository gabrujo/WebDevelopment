using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankRPSQL.ServicesBusiness;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankRPSQL.Pages
{
    public class ShowBalancesModel : PageModel
    {
        IBusinessBanking _ibusbank = null;
        public ShowBalancesModel(IBusinessBanking ibusbank)
        {
            _ibusbank = ibusbank;
        }
        public decimal CheckingBalance { get; set; }
        public decimal SavingBalance { get; set; }
        public void OnGet()
        {
            CheckingBalance = _ibusbank.GetCheckingBalance(10000);
            SavingBalance = _ibusbank.GetSavingBalance(100000);
        }
    }

}

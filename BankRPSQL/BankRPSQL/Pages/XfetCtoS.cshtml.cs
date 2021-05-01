using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankRPSQL.ServicesBusiness;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankRPSQL.Pages
{
    public class XferCToSModel : PageModel
    {
        IBusinessBanking _ibusbank = null;
        public XferCToSModel(IBusinessBanking ibusbank)
        {
            _ibusbank = ibusbank;
        }
        public decimal CheckingBalance { get; set; }
        public decimal SavingBalance { get; set; }
        [BindProperty]
        public decimal TransferAmount { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
            CheckingBalance = _ibusbank.GetCheckingBalance(10000);
            SavingBalance = _ibusbank.GetSavingBalance(100000);
            Message = "";
            TransferAmount = 0;
        }
        public void OnPost()
        {
            bool ret = _ibusbank.TransferCheckingToSaving(10000, 100000, TransferAmount);
            if (ret == true)
            {
                CheckingBalance = _ibusbank.GetCheckingBalance(10000);
                SavingBalance = _ibusbank.GetSavingBalance(100000);
                Message = "Transfer succeeded..";
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRPEF.Models.ViewModels
{
    public class TransactionHistoryVM : TransactionHistories
    {
        public string TransactionTypeName { get; set; } // added field
        public object CheckingAccountNumber { get; internal set; }
        public object SavingAccountNumber { get; internal set; }
        public object Amount { get; internal set; }
        public object TransactionFee { get; internal set; }
        public object TransactionDate { get; internal set; }
    }
}

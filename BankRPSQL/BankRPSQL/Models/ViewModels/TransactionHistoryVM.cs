using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRPSQL.Models.ViewModels
{
    public class TransactionHistoryVM
    {
        public string TransactionTypeName
        {
            get;
            set;
        }
        public string TransactionDate
        {
            get;
            set;
        }
        public string CheckingAccountNumber
        {
            get;
            set;
        }
        public string SavingAccountNumber
        {
            get;
            set;
        }
        public string Amount
        {
            get;
            set;
        }
        public string TransactionFee
        {
            get;
            set;
        }
    }
}

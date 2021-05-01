using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankRPSQL.DataLayer;

namespace BankRPSQL.Models.DomainModels
{
    public partial class TransactionHistory : EntityBase
    {
        public long TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public long CheckingAccountNumber { get; set; }
        public long SavingAccountNumber { get; set; }
        public decimal Amount { get; set; }
        public decimal TransactionFee { get; set; }
        public int TransactionTypeId { get; set; }
    }
}

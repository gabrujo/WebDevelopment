﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankRPEF.ServicesBusiness;
using BankRPSQL.DataLayer;


namespace BankRPSQL.ServicesBusiness
{
    public class BusinessBanking : IBusinessBanking
    {
        IRepositoryBanking _irepbank = null;
        public BusinessBanking(IRepositoryBanking ibank)
        {
            _irepbank = ibank;
        }
        public BusinessBanking(MYBANKContext context) : this(new RepositoryEF(context))
        { }
        public decimal GetCheckingBalance(long checkingAccountNum)
        {
            return _irepbank.GetCheckingBalance(checkingAccountNum);
        }
        public decimal GetSavingBalance(long savingAccountNum)
        {
            return _irepbank.GetSavingBalance(savingAccountNum);
        }
        public long GetCheckingAccountNumForUser(string username)
        {
            return _irepbank.GetCheckingAccountNumForUser(username);
        }
        public long GetSavingAccountNumForUser(string username)
        {
            return _irepbank.GetSavingAccountNumForUser(username);
        }

 public bool TransferCheckingToSaving(long checkingAccountNum, long
savingAccountNum, decimal amount)
        {
            return _irepbank.TransferCheckingToSaving(checkingAccountNum,
           savingAccountNum, amount, 0);
        }
        public bool TransferSavingToChecking(long checkingAccountNum, long
       savingAccountNum, decimal amount)
        {
            throw new NotImplementedException();
        }
        List<TransactionHistoryVM> IBusinessBanking.GetTransactionHistory(long
       checkingAccountNum)
        {
            return _irepbank.GetTransactionHistory(checkingAccountNum);
        }
    }

}

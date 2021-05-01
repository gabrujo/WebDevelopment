﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankRPSQL.Models.ViewModels;

namespace BankRPSQL.ServicesBusiness
{
    public interface IBusinessBanking
    {
        decimal GetCheckingBalance(long checkingAccountNum);
        decimal GetSavingBalance(long savingAccountNum);
        long GetCheckingAccountNumForUser(string username);
        long GetSavingAccountNumForUser(string username);
        bool TransferCheckingToSaving(long checkingAccountNum, long savingAccountNum,
       decimal amount);
        bool TransferSavingToChecking(long checkingAccountNum, long savingAccountNum,
       decimal amount);
        List<TransactionHistoryVM> GetTransactionHistory(long checkingAccountNum);
    }
}

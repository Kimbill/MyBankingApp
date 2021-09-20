using BankingApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankingApp.Interfaces
{
    public interface ITransactions
    {
        bool AddTransactionToDB(Transactions transaction);
        Transactions GetTransaction(string accNumber);
        List<Transactions> GetAllTransactions(string accNumber);
    }
}

using BankingApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankingApp.Model
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string AccountOwnerId { get; set; }
        public decimal Balance { get; set; }
        public virtual string AccType { get; } = "savings";
        public virtual string AccPrefix { get; } = "21";
        public virtual decimal WithdrawalLimit { get; } = 1000.00m;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;

        public List<Transactions> TransactionsHistory { get; set; }
    }
}

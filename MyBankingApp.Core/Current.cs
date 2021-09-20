using MyBankingApp.Model;
using System;
using System.Collections.Generic;

namespace BankingApp.Model
{
    public class Current : Account
    {

        public override string AccType { get; } = "current";
        public override string AccPrefix { get; } = "31";
        public override decimal WithdrawalLimit { get; } = 0.00m;

        // constructor
        public Current()
        {
            string generated;
            Random generator = new Random();
            generated = AccPrefix + generator.Next(0, 999999).ToString("D8");
            AccountNumber = generated;
            TransactionsHistory = new List<Transactions>();
        }

        // constructor with parameters and channing
        public Current(string ownerId, string accType) : this()
        {
            AccountOwnerId = ownerId;
            AccType = accType;
        }
    }
}

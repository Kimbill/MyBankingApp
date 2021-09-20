using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Model
{
    public class Transactions
    {
        // class properties
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public string AccType { get; set; }
        public DateTime DateOfTransaction { get; set; }

        // empty constructor
        public Transactions()
        {
            DateOfTransaction = DateTime.Now;
            Id = Guid.NewGuid().ToString();
        }

        // parameterized constructor and channing
        public Transactions(string accNum, decimal amt, string note, string type) : this()
        {
            AccountNumber = accNum;
            Amount = amt;
            Note = note;
            AccType = type;
        }
    }

    
}

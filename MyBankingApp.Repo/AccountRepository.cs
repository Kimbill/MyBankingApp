using BankingApp.Model;
using MyBankingApp.Data;
using MyBankingApp.Infrastructures;
using MyBankingApp.Interfaces;
using MyBankingApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankingApp.Repo
{
    public class AccountRepository : IAccounts
    {
        public int AccountCount { get; private set; }
        
        private TransactionRepository _transactionRepository;

        // constructor
        public AccountRepository()
        {
            //AccountCount = 
            AccountCount = CsvReader.CountOfAcctDB();
            _transactionRepository = new TransactionRepository();
        }

        // get owner account list by owner id
        public List<Account> GetUserAccounts(string ownerId)
        {
            var lstAccts = new List<Account>();
            foreach (var acct in GetAllAccounts())
            {
                if (acct.AccountOwnerId == ownerId)
                {
                    lstAccts.Add(acct);
                    return lstAccts;
                }
            }
            return null;
        }

        public List<Account> GetAllAccounts()
        {
            var acct = new List<Account>();
            foreach (var row in CsvReader.ReadAcctFileDB())
            {
                Account acc = new Savings
                {
                    AccountOwnerId = row.Split(",")[1].Trim(),
                    AccountNumber = row.Split(",")[0].Trim(),
                    Balance = decimal.Parse(row.Split(",")[3].Trim()),
                    DateCreated = DateTime.Parse(row.Split(",")[4].Trim()),
                    DateUpdated = DateTime.Parse(row.Split(",")[5].Trim()),
                };

                acct.Add(acc);
            }

            return acct;
        }

        // get accout by account number
        public Account GetAccountByAccNum(string acctNum)
        {
            foreach (var acct in GetAllAccounts())
            {
                if (acct.AccountNumber == acctNum)
                    return acct;
            }
            return null;
        }

        // add new account
        public bool AddAccountToDB(Account account)
        {
            try
            {
                CsvWriter.AddAccountToDB(account.AccountNumber, account.AccountOwnerId, account.AccType,
                    account.Balance, account.DateCreated, account.DateUpdated);
                return true;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("An error occured", ex);
            }
        }


        /// <summary>
        /// Make deposit into a given account
        /// </summary>
        /// <param name="accountNum"></param>
        /// <param name="amount"></param>
        /// <param name="date"></param>
        /// <param name="note"></param>
        // make deposite
        public void MakeDeposite(string accountNum, decimal amount, string type, string note )
        {
            // ensure the amount is not less than zero
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be positive");
            }

            var countBeforDeposit = _transactionRepository.CountTransact();

            // add a new deposit
            Transactions deposit = new Transactions(accountNum, amount, note, type);
            _transactionRepository.AddTransactionToDB(deposit);

            var countAfterDeposit = _transactionRepository.CountTransact();
            if (countAfterDeposit <= countBeforDeposit)
            {
                throw new Exception("Failed to add transaction!");
            }

        }

        // make withdrawal
        public virtual void MakeWithdrawal(string accNum, decimal amt, string note, string type)
        {
            // ensure the amount is not less than zero
            if (amt < 0)
                throw new ArgumentOutOfRangeException(nameof(amt), "Deposit amount must be positive");

            var bal = GetBalance(accNum);

            // ensure the amount left after withdrawals for savings don't got below 100
            if ((bal - amt) < 1000)
                throw new InvalidOperationException("You don't have sufficient fund for this operation");

            // add a new deposit
            Transactions withdrawal = new Transactions(accNum, -amt, note, type);
            _transactionRepository.AddTransactionToDB(withdrawal);
        }

        // make transfer
        public void MakeTransfer(string senderNumber, string receiverNumber, decimal amt, string note, string type)
        {
            // ensure the amount is not less than zero
            if (amt < 0)
                throw new ArgumentOutOfRangeException(nameof(amt), "Transfer amount must be positive");

            // ensure number exists
            if (!NumberExists(receiverNumber))
                throw new InvalidOperationException("The receiver number is not recognised!");

            // ensure that the sender number and the receiver number is not the same
            if (senderNumber == receiverNumber)
                throw new InvalidOperationException("Transfer amount within same account is not allowed!");

            // withdraw from the sender and deposit to the receiver
            MakeWithdrawal(senderNumber, amt, note, type);
            MakeDeposite(receiverNumber, amt, note, type);
        }

        // check if number exists
        private bool NumberExists(string receiverNumber)
        {
            foreach (var account in GetAllAccounts())
            {
                if (account.AccountNumber == receiverNumber)
                {
                    return true;
                }
            }
            return false;
        }


        // get balance
        public decimal GetBalance(string accountNumber)
        {
            decimal bal = 0;
            foreach (var row in _transactionRepository.GetAllTransactions(accountNumber))
            {
                if (row.AccountNumber == accountNumber)
                    bal += row.Amount;
            }
            return bal;
        }
    }
}

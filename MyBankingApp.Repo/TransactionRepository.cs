using BankingApp.Model;
using MyBankingApp.Data;
using MyBankingApp.Infrastructures;
using MyBankingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankingApp.Repo
{
    public class TransactionRepository: ITransactions
    {
        public int TransactCount { get; private set; }
        public readonly string filePath = @"C:\Users\hp\source\repos\week_4_task_mybankapp-main\User.txt";

        public TransactionRepository()
        {
            TransactCount = AuthRepository.ReadFromFile(filePath).Count;
        }

        // add transaction
        public bool AddTransactionToDB(Transactions transaction)
        {
            try
            {
                CsvWriter.AddToTransactionDB(transaction.Id, transaction.AccountNumber, transaction.Amount, transaction.AccType,
                    transaction.Note, transaction.DateOfTransaction);
                return true;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("An error occured", ex);
            }
        }

        // count rows
        public int CountTransact()
        {
            return CsvReader.ReadTransFileDB().Count;
        }

        // get single transaction by account number
        public Transactions GetTransaction(string accNumber)
        {
            foreach (var row in CsvReader.ReadTransFileDB())
            {
                if (row.Split(",")[1].Trim() == accNumber)
                {
                    var accToReturn = new Transactions
                    {
                        Id = row.Split(",")[0].Trim(),
                        AccountNumber = row.Split(",")[1].Trim(),
                        Amount = decimal.Parse(row.Split(",")[2].Trim()),
                        Note = row.Split(",")[4].Trim(),
                        AccType = row.Split(",")[3].Trim(),
                        DateOfTransaction = DateTime.Parse(row.Split(",")[5].Trim()),
                    };
                    return accToReturn;
                };
            }

            return null;
        }

        // get all transaction by account number
        public List<Transactions> GetAllTransactions(string accNumber)
        {
            List<Transactions> lstTransact = new List<Transactions>();
            foreach (var row in CsvReader.ReadTransFileDB())
            {
                if (row.Split(",")[1].Trim() == accNumber)
                {
                    var accToReturn = new Transactions
                    {
                        Id = row.Split(",")[0].Trim(),
                        AccountNumber = row.Split(",")[1].Trim(),
                        Amount = decimal.Parse(row.Split(",")[2].Trim()),
                        Note = row.Split(",")[4].Trim(),
                        AccType = row.Split(",")[3].Trim(),
                        DateOfTransaction = DateTime.Parse(row.Split(",")[5].Trim()),
                    };
                    lstTransact.Add(accToReturn);
                };
            }

            return lstTransact;
        }
    }
}

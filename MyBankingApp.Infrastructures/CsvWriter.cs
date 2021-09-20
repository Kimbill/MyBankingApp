using System;

namespace MyBankingApp.Infrastructures
{
    public class CsvWriter
    {

        public static readonly string accFilePath = @"C:\Users\hp\source\repos\week_4_task_mybankapp-main\Account.txt";
        public static readonly string transFilePath = @"C:\Users\hp\source\repos\week_4_task_mybankapp-main\Transaction.txt";
        public static bool AddUserDatailsToDB(string id, string email, string passwordhash, string passwordsalt,
            string firstname, string lastname, string fullname, string filePath)
        {
            try
            {
                using System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true);
                file.WriteLine($"{ id}, { email}, {passwordhash}, {passwordsalt}," +
                    $"{firstname}, {lastname}, {fullname}");
                return true;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("An error occured", ex);
            }
        }

        public static bool AddAccountToDB(string acctnum, string ownerid, string acctType, decimal bal,
            DateTime dateCreated, DateTime dateModi)
        {
            try
            {
                using System.IO.StreamWriter file = new System.IO.StreamWriter(accFilePath, true);
                file.WriteLine($"{acctnum}, {ownerid}, {acctType}, {bal}," +  $"{dateCreated}, {dateModi}");
                return true;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("An error occured", ex);
            }
        }

        public static bool AddToTransactionDB(string id, string acctNum, decimal amount, string accType,
            string note, DateTime date)
        {
            try
            {
                using System.IO.StreamWriter file = new System.IO.StreamWriter(transFilePath, true);
                file.WriteLine($"{id}, {acctNum}, {amount}, {accType}," + $"{note}, {date}");
                return true;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("An error occured", ex);
            }
        }
    }
}

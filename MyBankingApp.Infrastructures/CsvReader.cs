using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyBankingApp.Infrastructures
{
    public class CsvReader
    {

        public static readonly string accFilePath = @"C:\Users\hp\source\repos\week_4_task_mybankapp-main\Account.txt";
        public static readonly string transFilePath = @"C:\Users\hp\source\repos\week_4_task_mybankapp-main\Transaction.txt";
        public static List<string> ReadFromFileDB(string filePath)
        {
            try
            {
                List<string> result = new List<string>();
                result = File.ReadAllLines(filePath).ToList();

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("An Error occured while reading from file", ex);
            }
        }

        public static List<string> ReadAcctFileDB()
        {
            try
            {
                List<string> result = new List<string>();
                result = File.ReadAllLines(accFilePath).ToList();

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("An Error occured while reading from file", ex);
            }
        }

        public static int CountOfAcctDB()
        {
            List<string> result = File.ReadAllLines(accFilePath).ToList();

            return result.Count;
            
        }

        public static List<string> ReadTransFileDB()
        {
            try
            {
                List<string> result = new List<string>();
                result = File.ReadAllLines(transFilePath).ToList();

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("An Error occured while reading from file", ex);
            }
        }
    }
}

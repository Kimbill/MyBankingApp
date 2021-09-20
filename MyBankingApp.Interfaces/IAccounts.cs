using MyBankingApp.Model;
using System.Collections.Generic;

namespace MyBankingApp.Interfaces
{
    public interface IAccounts
    {
        List<Account> GetUserAccounts(string ownerId);
        List<Account> GetAllAccounts();
        Account GetAccountByAccNum(string acctNum);
        bool AddAccountToDB(Account account);
        void MakeDeposite(string accountNum, decimal amount, string type, string note);
        void MakeWithdrawal(string accNum, decimal amt, string note, string type);
        decimal GetBalance(string accountNumber);
    }
}

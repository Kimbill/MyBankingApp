using BankingApp.Model;
using MyBankingApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankingApp.Interfaces
{
    public interface IUser
    {
        bool AddUserToDB(User user, string filePath);
        User GetUserById(string id);
        User GetUserByEmail(string email);
        int UsersCount();
    }
}

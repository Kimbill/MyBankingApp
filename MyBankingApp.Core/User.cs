using MyBankingApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Model
{
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public List<Account> Accounts { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += " ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        // empty constructor
        public User()
        {
            Accounts = new List<Account>();
        }
        public User(string firstname, string lastname, string email) : this()
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
        }

    }
}

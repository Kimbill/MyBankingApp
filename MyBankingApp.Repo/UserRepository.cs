using MyBankingApp.Data;
using MyBankingApp.Model;
using MyBankingApp.Infrastructures;
using MyBankingApp.Interfaces;
using System;
using BankingApp.Model;

namespace MyBankingApp.Repo
{
    public class UserRepository : IUser
    {
        public int NumUsersCount { get; private set; }
        private readonly AccountRepository _accountRepository;
        public readonly string filePath = @"C:\Users\hp\source\repos\week_4_task_mybankapp-main\User.txt";

        // intantiate NumUserCount in constructor
        public UserRepository()
        {
            NumUsersCount = AuthRepository.ReadFromFile(filePath).Count;
            _accountRepository = new AccountRepository();
        }

        // count rows
        public int UsersCount()
        {
            return AuthRepository.ReadFromFile(filePath).Count;
        }


        public bool AddUserToDB(User user, string filePath)
        {
            try
            {
                CsvWriter.AddUserDatailsToDB(user.Id, user.Email, Convert.ToBase64String(user.PasswordHash),
                    Convert.ToBase64String(user.PasswordSalt), user.FirstName, user.LastName, user.FullName, filePath);
                return true;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("An error occured", ex);
            }
        }

        public User GetUserById(string id)
        {
            foreach (User user in AuthRepository.ReadFromFile(filePath))
            {
                if (user.Id == id)
                {
                    
                    return user;
                }
                
            }
            return null;
        }

        public User GetUserByEmail(string email)
        {
            foreach (User user in AuthRepository.ReadFromFile(filePath))
            {
                if (user.Email == email)
                {

                    var usertoReturn = new User
                    {
                        Id = user.Id,
                        Email = user.Email,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        PasswordSalt = user.PasswordSalt,
                        PasswordHash = user.PasswordHash,
                        Accounts = _accountRepository.GetUserAccounts(user.Id),
                    };
                    return usertoReturn;
                }

            }
            return null;
        }
    }
}

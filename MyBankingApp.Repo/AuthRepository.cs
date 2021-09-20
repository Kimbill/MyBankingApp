using BankingApp.Model;
using MyBankingApp.Data;
using MyBankingApp.Infrastructures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyBankingApp.Repo
{
    public class AuthRepository
    {
        public static string loggedInUserId;
        private readonly UserRepository _userRepository;
        public readonly string filePath = @"C:\Users\hp\source\repos\week_4_task_mybankapp-main\User.txt";

        public AuthRepository()
        {
            _userRepository = new UserRepository();
        }

        public bool RegisterUser(string firstname, string lastname, string email, string password)
        {
            // construct the user object
            var user = new User(firstname, lastname, email);

            // check if email is valid
            if (!Utilities.Utilities.EmailValidator(email))
                throw new Exception("Email is not valid");

            // Register using repository
            return Register(user, password);
        }

        // register
        public bool Register(User user, string password)
        {
            // check if email already exist
            if (EmailExist(user.Email))
                throw new Exception("Email already exists");

            // generate password hash
            var hashes = Utilities.Utilities.GenerateHash(password);
            user.PasswordHash = hashes[0];
            user.PasswordSalt = hashes[1];

            // add user to data source
            if (_userRepository.AddUserToDB(user, filePath))
            {
                return true;
            }

            return false;
        }

        // email exists
        internal bool EmailExist(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                foreach (var row in ReadFromFile(filePath))
                {
                    if (row.Email == email)
                        return true;
                }
            }
            return false;
        }

        // validate login credentials
        private bool IsValidCred(string email, string password)
        {
            bool passwordMatch = false;

            // check if user table contains records
            if (_userRepository.UsersCount() < 1)
            {
                throw new Exception("No record found in data source");
            }

            // get user by email
            foreach (var user in ReadFromFile(filePath))
            {
                if (user.Email == email)
                {
                    if (Utilities.Utilities.CompareHash(user.PasswordSalt, user.PasswordHash, password))
                    {
                        passwordMatch = true;
                        return passwordMatch;
                    }
                }
            }
            return passwordMatch;
        }



        /// <summary>
        /// Login User
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User Login(string email, string password)
        {
            // check if email is valid
            if (!Utilities.Utilities.EmailValidator(email))
                throw new Exception("Email is not valid");

            foreach (User user in ReadFromFile(filePath))
            {
                if (user.Email == email)
                {
                    if (!IsValidCred(email, password))
                        throw new Exception("Invalid credentials");

                    var loggedInUser = _userRepository.GetUserByEmail(email);
                    return loggedInUser;
                }
            }
            return null;
        }

        public static List<User> ReadFromFile(string filePath)
        {
            try
            {
                List<User> users = new List<User>();
                foreach (var row in CsvReader.ReadFromFileDB(filePath))
                {
                    var user = new User
                    {
                        Id = row.Split(",")[0].Trim(),
                        Email = row.Split(",")[1].Trim(),
                        FirstName = row.Split(",")[4].Trim(),
                        LastName = row.Split(",")[5].Trim(),
                        PasswordSalt = Convert.FromBase64String(row.Split(",")[3].Trim()),
                        PasswordHash = Convert.FromBase64String(row.Split(",")[2].Trim()),
                    };

                    users.Add(user);
                }

                return users;
            }
            catch (Exception ex)
            {

                throw new Exception("An Error occured while reading from file", ex);
            }
        }
    }
}

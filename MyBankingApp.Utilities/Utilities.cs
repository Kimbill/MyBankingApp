using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MyBankingApp.Utilities
{
    public class Utilities
    {
        /// <summary>
        /// String sanitizer
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string RemoveDigits(string val)
        {
            var str = val.Substring(0, 1).ToCharArray();
            var strCode = (int)str[0];
            if (strCode >= 48 && strCode <= 57)
            {
                val = val.Substring(1);
                return (strCode >= 48 && strCode <= 57) ? RemoveDigits(val) : val;
            }

            return val;
        }

        // Change first character to caps
        public static string FirstCharacterToUpper(string val)
        {
            var str = val.Substring(0, 1).ToCharArray();
            var strCode = (int)str[0];
            if (strCode >= 97)
            {
                var strCaps = strCode - 32;
                return (char)strCaps + val.Substring(1);
            }

            return val;
        }

        // Generate hash
        //public static string[] GenerateHash(string password, int size)
        //{
        //    var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
        //    var buff = new byte[size];
        //    rng.GetBytes(buff);
        //    Console.WriteLine($"Buff:: {buff}");
        //    Console.WriteLine($"Converted Buff:: {Convert.ToBase64String(buff)}");
        //    byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password + Convert.ToBase64String(buff));
        //    System.Security.Cryptography.SHA256Managed hA256hashingstring =
        //        new System.Security.Cryptography.SHA256Managed();
        //    byte[] hash = hA256hashingstring.ComputeHash(bytes);
        //    string[] result = { ByteArrayToHexString(hash), Convert.ToBase64String(buff) };
        //    return result;
        //}


        //public static string ByteArrayToHexString(byte[] byts)
        //{
        //    StringBuilder hex = new StringBuilder(byts.Length * 2);
        //    foreach (byte b in byts)
        //    {
        //        hex.AppendFormat("{0:x2}", b);
        //    }
        //    return hex.ToString();
        //    ;
        //}

        //public static byte[] HexStringToByteArray(string hex)
        //{
        //    int NumberChars = hex.Length;
        //    byte[] bytes = new byte[NumberChars / 2];
        //    for (int i = 0; i < NumberChars; i += 2)
        //    {
        //        bytes[1 / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
        //    }
        //    return bytes;
        //}

        // Create Salt
        public static String CreateSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        // Generate hash
        public static List<byte[]> GenerateHash(string password)
        {
            byte[] passwordSalt, passwordHash;

            // convert password to hash value and generate salt
            using (var hash = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hash.Key;
                passwordHash = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

            var result = new List<byte[]>();
            result.Add(passwordHash);
            result.Add(passwordSalt);

            return result;
        }


        // compare password hash
        public static bool CompareHash(byte[] passwordSalt, byte[] passwordHash, string password)
        {
            using (var hash = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var hashGenerated = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < hashGenerated.Length; i++)
                {
                    if (hashGenerated[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Handle error that may occur due to user inputing digits only as name
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool DigitInput(string val)
        {
            bool num = long.TryParse(val, out long name);
            if (num)
            {
                return !num;
            }
            return true;
        }


        /// <summary>
        /// Regex for email validation
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool EmailValidator(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)(\.(\w{2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }
            return false;
        }


        #region PRINT TABLE UTILITY CODE
        public static void PrintLine(int widthOfTable)
        {
            Console.WriteLine(new string('-', widthOfTable));
        }

        public static void PrintRow(int widthOfTable, params string[] columns)
        {
            int width = (widthOfTable - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += CenterText(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        public static string CenterText(string column, int width)
        {
            column = column.Length > width ? column.Substring(0, width - 3) + "..." : column;

            if (!string.IsNullOrEmpty(column))
            {
                return column.PadRight(width - (width - column.Length) / 2).PadLeft(width);
            }
            else
            {
                return new string(' ', width);
            }
        }

        #endregion
    }
}

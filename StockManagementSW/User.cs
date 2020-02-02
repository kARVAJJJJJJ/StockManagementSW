using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace StockManagementSW
{
    enum UserType {BASIC, NORMAL, ADMIN }
        

    class User
    {
        private int id;
        private string username;
        private string hashedpassword;
        private UserType type;

        public int Id { get => id; set => id = value; }

        public string Username
        {
            get => username;
            set
            {
                if (value.Length < 5)
                {
                    username = value;
                }
                else
                {
                    throw new ArgumentException("felh hossz");
                }
            } 
        }

        public string HashedPassword
        {
            get => hashedpassword;
            set
            {
                if (value.Length == 64)
                {
                    hashedpassword = value;
                }
                else
                {
                    throw new ArgumentException("pw hossz");
                }
            }
        }

        public UserType Type { get => type; set => type = value; }
        
        public User(int id, string username, string hashedpassword, UserType type)
        {
            Id = id;
            Username = username;
            HashedPassword = hashedpassword;
            Type = type;
        }

        static string HashThePassword (string PWtohash)
        {
            SHA256CryptoServiceProvider p = new SHA256CryptoServiceProvider();
            byte[] binaryHashedPassword = p.ComputeHash(Encoding.UTF8.GetBytes(PWtohash));
            return BitConverter.ToString(binaryHashedPassword).Replace("-", "");
        }
    }
}

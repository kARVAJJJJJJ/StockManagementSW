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
                if (value.Length > 3)
                {
                    username = value;
                }
                else
                {
                    throw new ArgumentException("felhasználónév hossz");
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

        public User()
        {

        }

        public User(string username, string hashedpassword, UserType type)
        {
            Username = username;
            HashedPassword = hashedpassword;
            Type = type;
        }

        public User(int id, string username, string hashedpassword, UserType type)
        {
            Id = id;
            Username = username;
            HashedPassword = hashedpassword;
            Type = type; 
        }
                        
    }
}

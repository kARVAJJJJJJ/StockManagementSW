using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace StockManagementSW
{
    //enum UserType {BASIC, NORMAL, ADMIN }
    
    public class User
    {
        #region változók
        private int id;
        //private string username;
        private string fullname;
        private string hashedusername;
        private string hashedpassword;
        private bool isactive;
        private bool isadmin;
        //private UserType type;
        #endregion

        #region get set
        public int Id { get => id; set => id = value; }
        /*
        public string Username
        {
            get => username;
            set
            {
                if (value.Length >= 5)
                {
                    username = value;
                }
                else
                {
                    throw new ArgumentException("A felhasználónév minimum 5 karakter hosszú kell legyen!");
                }
            }
        }
        */
        public string Fullname
        {
            get => fullname;
            set
            {
                if (value.Length >= 5)
                {
                    fullname = value;
                }
                else
                {
                    throw new ArgumentException("A teljes név minimum 5 karakter hosszú kell legyen!");
                }
            }
        }

        public string HashedUsername
        {
            get => hashedusername;
            set
            {
                if (value.Length == 64)
                {
                    hashedusername = value;
                }
                else
                {
                    throw new ArgumentException("A hash felhasználónév hossza nem megfelelő!");
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
                    throw new ArgumentException("A jelszó hash hossza nem megfelelő!");
                }
            }
        }

        public bool Isactive { get => isactive; set => isactive = value; }

        public bool Isadmin { get => isadmin; set => isadmin = value; }

        //public UserType Type { get => type; set => type = value; }
        #endregion

        #region konstruktorok
        
        public User(string fullname, string hashedUsername, string hashedPassword, bool isactive, bool isadmin)
        {
            //Username = username;
            Fullname = fullname;
            HashedUsername = hashedUsername;
            HashedPassword = hashedPassword;
            Isactive = isactive;
            Isadmin = isadmin;
        }

        public User()
        {

        }
        /*
        public User(string username, string hashedpassword)
        {
            Username = username;
            HashedPassword = hashedpassword;
        }

        public User(int id, string username, string hashedpassword)
        {
            Id = id;
            Username = username;
            HashedPassword = hashedpassword;
        }
        */


        #endregion

        public override string ToString()
        {
            return Fullname + " - " + "Active user: " + Isactive + " - " + "Admin user: " + Isadmin;
        }
    }
}

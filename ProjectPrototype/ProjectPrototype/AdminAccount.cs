using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPrototype
{
    public class AdminAccount
    {
        private string username;
        private string password;

        public AdminAccount(string user, string pass)
        {
            this.username = user;
            this.password = pass;
        }

        private void loadInDatabase(string user, string pass)
        {
            System.IO.File.AppendAllText(@"database/Admins.txt", user + Environment.NewLine);
            System.IO.File.AppendAllText(@"database/AdminPasswords.txt", pass + Environment.NewLine);
        }

        public bool VerifyAccount(string user, string pass)
        {
            if (username == user && password == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

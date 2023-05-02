using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPrototype
{
    public class Admin
    {
        string username;
        string password;

        public Admin(string givenUsername, string givenPassword)
        {
            this.username = givenUsername;
            this.password = givenPassword;
        }
    }
}

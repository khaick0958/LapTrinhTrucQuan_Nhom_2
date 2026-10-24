using System;
using System.Collections.Generic;
using System.Text;

namespace TiviManagementApp.Services
{
    internal class Validate_Login
    {
        public Validate_Login()
        {
        }

        public Validate_Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        private string username {  get; set; }
        private string password { get; set; }

        public bool isValid()
        {
            if (username == "admin" && password == "UTC")
            {
                return true;
            }
            return false;
        }
    }
}

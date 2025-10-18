using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_AuthMechanism_Assignment1
{
    internal class User
    {
        private string _username { get; set; }
        private string _password { get; set; }
        private string _email { get; set; }
        private int _number { get; set; }

        //public string getUsername() { return _username; }
        //public string getPassword() { return _password; }
        //public string getPhone() { return _number.ToString(); }
        //public string getEmail() { return _email; }

        public User(string username, string password)
        {
            this._username = username;
            this._password = password;
            //this._email = email;
            //this._number = number;

        }
        public User(int number) 
        {
            this._number = number;   
        }
        public User(string email)
        {
            this._email = email;
        }





    }
}

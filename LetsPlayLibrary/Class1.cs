using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPlayLibrary
{
    public class User
    {
        private string _login;
        private string _email;
        private char _gender;
        private string _password;

        public string Login {
            get { return _login; }
            set
            {
                if (value != null && value.Length < 12)
                    _login = value;
            }
        }
        public string Email {
            get { return _email; }
            set
            {
                if (value != null)
                    _email = value;
            }
        }
        public char Gender {
            get { return _gender; }
            set
            {
                if (value != 'm' || value != 'f')
                    _gender = value;
            }
        }
        public string Password {
            get { return _password; }
            set
            {
                if (value != null && value.Length > 4 && value.Length <= 20)
                    _password = value;
            }
        }

        public User(string login, string email, string password)
        {
            Login = login;
            Email = email;
            Password = password;
        }
    }
}

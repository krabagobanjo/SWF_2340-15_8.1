using System;
using System.Collections.Generic;
using System.Text;

namespace SWF_2340_15_8._1
{
    class Registrar
    {
        private string username;
        private string name;
        private string email;
        private string password;
        private string passwordConfirm;

        public Registrar(string name, string user, string email, string password, string passwordConfirm)
        {
            this.name = name;
            username = user;
            this.email = email;
            this.password = password;
            this.passwordConfirm = passwordConfirm;
        }

        public Boolean passwordCheck()
        {
            return password.Equals(passwordConfirm);
        }

        public User makeUser()
        {
            return new User(name, username, email, password);
        }
    }
}

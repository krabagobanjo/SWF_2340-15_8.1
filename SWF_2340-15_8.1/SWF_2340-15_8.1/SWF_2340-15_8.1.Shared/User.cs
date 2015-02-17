using System;
using System.Collections.Generic;
using System.Text;

namespace SWF_2340_15_8._1
{
    class User
    {
        private string username;
        private string name;
        private string email;
        private string password;
        private List<double> rating;
        private List<string> friends;
        private bool authenticated;

        public User(string name, string user, string email, string password)
        {
            this.name = name;
            username = user;
            this.email = email;
            this.password = password;
            rating = new List<double>();
            friends = new List<string>();
            authenticated = false;
        }

        public bool AuthStatus
        {
            get { return authenticated; }
            set { authenticated = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value;  }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        
        public double getRating()
        {
            if (rating.Count == 0) return 0;
            else
            {
                double sum = 0;
                foreach (double d in rating) sum += d;
                if (sum == 0) return 0;
                else return (double) sum / rating.Count;
            }
        }

        public List<string> getFriends()
        {
            return friends;
        }
    }
}

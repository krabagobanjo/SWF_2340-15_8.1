using System;
using System.Collections.Generic;
using System.Text;

namespace SWF_2340_15_8._1
{
    class User
    {
        public string Name { get; private set; }
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string friendsList { get; private set; }
        public string Ratings { get; private set; }

        public User(string name, string user, string email, string password)
        {
            Name = name;
            Username = user;
            Email = email;
            Password = password;
            Ratings = "";
            friendsList = "";
        }

        public User(string name, string user, string email, string ratings, string friends)
        {
            Name = name;
            Username = user;
            Email = email;
            Ratings = ratings;
            friendsList = friends;
        }

        public double getRating()
        {
            string[] rats = Ratings.Split(new char[1] {','});
            if (rats.Length == 0) return 0;
            else
            {
                double sum = 0;
                foreach (string s in rats)
                {
                    double temp = Convert.ToDouble(s);
                    sum += temp;
                }
                if (sum == 0) return 0;
                else return (double) sum / rats.Length;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SWF_2340_15_8._1
{
    [Table("Users")]
    class UserTable
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public double rating { get; set; }
        public string friends { get; set; }
        public bool authStatus { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_TEST_APP.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Usertype { get; set; }
        public string Password { get; set; }
        public User(Guid id, string name, string username, string password, string usertype)
        {
            ID = id;
            Name = name;
            UserName = username;
            Password = password;
            Usertype = usertype;
        }
    }
}

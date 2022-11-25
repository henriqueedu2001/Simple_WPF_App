using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_TEST_APP.Models;

namespace WPF_TEST_APP
{
    public static class Autentication
    {
        private static List<User> Users = new List<User>();
        public static bool AutenticateUser(string username, string password)
        {
            foreach(var user in Users)
            {
                if(user.UserName == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static void AddUser(User user)
        {
            Users.Add(user);
        }
    }
}

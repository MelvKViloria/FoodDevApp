using FoodDevApp.MVVM.Model;
using System.Collections.Generic;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDevApp.MVVM.Services
{
    public static class userService
    {
        public static List<User> Users { get; } = new List<User>();

        public static void AddUser(User user)
        {
            Users.Add(user);
        }

        public static User GetUser(string username)
        {
            return Users.Find(u => u.UserName == username);
        }
    }
}

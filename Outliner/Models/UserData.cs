using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace Outliner.Models
{
    public static class UserData
    {
        private static List<User> users = new List<User>();

        public static List<User> DisplayAll()
        {
            List<User> userList = new List<User>();
            userList.AddRange(users);
            return userList;
        }

        public static void AddUser(User user)
        {
            users.Add(user);
        }
       
        //public static User GetUser();
    }
}

﻿using System.Collections.Generic;
using System.Linq;

namespace CourseWork.Model.Data.Service
{
    public class UserService
    {
        public static SynchronizedCollection<User> users = new(0);

        public static bool AuthUser(string nickname, string password)
        {
            using (ApplicationContext db = new())
            {
                bool isAuthenticated = db.Users.Any(u => u.Nickname == nickname & u.Password == password);
                if (isAuthenticated) return true;
            }
            return false;

        }
    }
}

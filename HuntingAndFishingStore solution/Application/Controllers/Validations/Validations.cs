using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data;
using Models;

namespace Application.Controllers.Validations
{
    public class Validations
    {
        public static bool IsUsernameExists(string username)
        {
            using (var context = new GunStoreContext())
            {
                return context.Users
                    .Any(u => u.Username == username);
            }
        }

        public static bool IsEmailExists(string email)
        {
            using (var context = new GunStoreContext())
            {
                return context.Users
                    .Any(e => e.Email == email);
            }
        }
    }
}
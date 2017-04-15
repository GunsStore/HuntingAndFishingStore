using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using Models;
using Models.Dtos;

namespace Application.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(AdminDto adminLogin)
        {
            var admin = adminLogin.Email == "GunAdmin@gmail.com" &&
                        adminLogin.Password == "adm1n";

            if (admin)
            {
                Session["Email"] = adminLogin.Email;
                ModelState.Clear();
                return RedirectToAction("AdminIndex");
            }

            ModelState.AddModelError("email and password", "Invalid email or password!");
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            ModelState.Clear();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult AdminIndex()
        {
            if (Session["Email"]==null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(GetUsers());
        }

        #region SupportMethods

        private static List<User> GetUsers()
        {
            using (var context = new GunStoreContext())
            {
                return context.Users.ToList();
            }
        }

        #endregion
    }
}
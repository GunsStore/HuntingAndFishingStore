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

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddBaton()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBaton(Baton baton)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    db.Batons.Add(baton);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("AddProduct","Admin");
                }
                ModelState.AddModelError("baton", "Invalid baton added");
                return View();
            }
        }

        [HttpGet]
        public ActionResult AddClothing()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddClothing(Clothing clothing)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    db.Clothes.Add(clothing);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("AddProduct", "Admin");
                }
                ModelState.AddModelError("clothing", "Invalid clothing added");
                return View();
            }
        }

        [HttpGet]
        public ActionResult AddFirearm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFirearm(Firearm firearm)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    db.Firearms.Add(firearm);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("AddProduct", "Admin");
                }
                ModelState.AddModelError("firearms", "Invalid firearms added");
                return View();
            }
        }

        [HttpGet]
        public ActionResult AddFlashlight()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFlashlight(Flashlight flashlight, HttpPostedFileBase image)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    if (flashlight != null)
                    {

                        flashlight.Image = new byte[image.ContentLength];
                        image.InputStream.Read(flashlight.Image, 0, image.ContentLength);
                    }
                    db.Flashlights.Add(flashlight);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("AddProduct", "Admin");
                }
                ModelState.AddModelError("flashlight", "Invalid flashlight added");
                return View();
            }
        }

        [HttpGet]
        public ActionResult AddHolster()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddHolster(Holster holster)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    db.Holsters.Add(holster);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("AddProduct", "Admin");
                }
                ModelState.AddModelError("holster", "Invalid holster added");
                return View();
            }
        }

        [HttpGet]
        public ActionResult AddKnife()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddKnife(Knife knife)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    db.Knives.Add(knife);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("AddProduct", "Admin");
                }
                ModelState.AddModelError("knife", "Invalid knife added");
                return View();
            }
        }

        [HttpGet]
        public ActionResult AddRound()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRound(Round round)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    db.Rounds.Add(round);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("AddProduct", "Admin");
                }
                ModelState.AddModelError("round", "Invalid round added");
                return View();
            }
        }

        [HttpGet]
        public ActionResult AddScope()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddScope(Scope scope)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    db.Scopes.Add(scope);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("AddProduct", "Admin");
                }
                ModelState.AddModelError("scope", "Invalid scope added");
                return View();
            }
        }

        [HttpGet]
        public ActionResult AddTazer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTazer(Tazer tazer)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    db.Tazers.Add(tazer);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("AddProduct", "Admin");
                }
                ModelState.AddModelError("tazer", "Invalid tazer added");
                return View();
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
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
            if (Session["Email"] == null)
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

        //AddingProducts

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
        public ActionResult AddBaton(BatonDTO batonDto)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    var baton = new Baton()
                    {
                        Name = batonDto.Name,
                        Description = batonDto.Description,
                        Price = batonDto.Price,
                        Quantity = batonDto.Quantity,
                        Weight = batonDto.Weight

                    };
                    if (batonDto.Image != null)
                    {
                        baton.Image = new byte[batonDto.Image.ContentLength];
                        batonDto.Image.InputStream.Read(baton.Image, 0, batonDto.Image.ContentLength);
                    }
                    db.Batons.Add(baton);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("AddProduct", "Admin");
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
        public ActionResult AddClothing(ClothingDTO clothingDto)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    var clothing = new Clothing()
                    {
                        Name = clothingDto.Name,
                        Description = clothingDto.Description,
                        Price = clothingDto.Price,
                        Quantity = clothingDto.Quantity,
                        Size = clothingDto.Size
                    };
                    if (clothingDto.Image != null)
                    {
                        clothing.Image = new byte[clothingDto.Image.ContentLength];
                        clothingDto.Image.InputStream.Read(clothing.Image, 0, clothingDto.Image.ContentLength);
                    }
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
        public ActionResult AddFirearm(FirearmDTO firearmDto)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    var firearm = new Firearm()
                    {
                        Name = firearmDto.Name,
                        Description = firearmDto.Description,
                        Price = firearmDto.Price,
                        Quantity = firearmDto.Quantity,
                        Model = firearmDto.Model

                    };
                    if (firearmDto.Image != null)
                    {
                        firearm.Image = new byte[firearmDto.Image.ContentLength];
                        firearmDto.Image.InputStream.Read(firearm.Image, 0, firearmDto.Image.ContentLength);
                    }
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
        public ActionResult AddFlashlight(FlashlightDTO flashlightDTO)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    var flashlight = new Flashlight()
                    {
                        Name = flashlightDTO.Name,
                        Description = flashlightDTO.Description,
                        Price = flashlightDTO.Price,
                        Quantity = flashlightDTO.Quantity,
                        BatteryType = flashlightDTO.BatteryType
                    };
                    if (flashlightDTO.Image != null)
                    {
                        flashlight.Image = new byte[flashlightDTO.Image.ContentLength];
                        flashlightDTO.Image.InputStream.Read(flashlight.Image, 0, flashlightDTO.Image.ContentLength);
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
        public ActionResult AddHolster(HolsterDTO holsterDto)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    var holster = new Holster()
                    {
                        Name = holsterDto.Name,
                        Description = holsterDto.Description,
                        Price = holsterDto.Price,
                        Quantity = holsterDto.Quantity,

                    };
                    if (holsterDto.Image != null)
                    {
                        holster.Image = new byte[holsterDto.Image.ContentLength];
                        holsterDto.Image.InputStream.Read(holster.Image, 0, holsterDto.Image.ContentLength);
                    }
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
        public ActionResult AddKnife(KnifeDTO knifeDto)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    var knife = new Knife()
                    {
                        Name = knifeDto.Name,
                        Description = knifeDto.Description,
                        Price = knifeDto.Price,
                        Quantity = knifeDto.Quantity,
                        Length = knifeDto.Length,
                        Width = knifeDto.Width

                    };
                    if (knifeDto.Image != null)
                    {
                        knife.Image = new byte[knifeDto.Image.ContentLength];
                        knifeDto.Image.InputStream.Read(knife.Image, 0, knifeDto.Image.ContentLength);
                    }
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
        public ActionResult AddRound(RoundDTO roundDto)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    var round = new Round()
                    {
                        Name = roundDto.Name,
                        Description = roundDto.Description,
                        Price = roundDto.Price,
                        Quantity = roundDto.Quantity,
                        Caliber = roundDto.Caliber

                    };
                    if (roundDto.Image != null)
                    {
                        round.Image = new byte[roundDto.Image.ContentLength];
                        roundDto.Image.InputStream.Read(round.Image, 0, roundDto.Image.ContentLength);
                    }
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
        public ActionResult AddScope(ScopeDTO scopeDto)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    var scope = new Scope()
                    {
                        Name = scopeDto.Name,
                        Description = scopeDto.Description,
                        Price = scopeDto.Price,
                        Quantity = scopeDto.Quantity,

                    };
                    if (scopeDto.Image != null)
                    {
                        scope.Image = new byte[scopeDto.Image.ContentLength];
                        scopeDto.Image.InputStream.Read(scope.Image, 0, scopeDto.Image.ContentLength);
                    }

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
        public ActionResult AddTazer(TazerDTO tazerDto)
        {
            using (var db = new GunStoreContext())
            {
                if (ModelState.IsValid)
                {
                    var tazer = new Tazer()
                    {
                        Name = tazerDto.Name,
                        Description = tazerDto.Description,
                        Price = tazerDto.Price,
                        Quantity = tazerDto.Quantity,
                        Voltage = tazerDto.Voltage

                    };
                    if (tazerDto.Image != null)
                    {
                        tazer.Image = new byte[tazerDto.Image.ContentLength];
                        tazerDto.Image.InputStream.Read(tazer.Image, 0, tazerDto.Image.ContentLength);
                    }

                    db.Tazers.Add(tazer);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("AddProduct", "Admin");
                }
                ModelState.AddModelError("tazer", "Invalid tazer added");
                return View();
            }
        }

        //RemovingProducts

        public ActionResult RemoveProduct()
        {
            return View();
        }
    }
}
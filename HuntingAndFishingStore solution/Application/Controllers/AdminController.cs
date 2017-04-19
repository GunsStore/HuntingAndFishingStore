using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Data;
using Models;
using Models.Dtos;
using System.Data.Entity;

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
            return View();
        }
       

        public ActionResult GetUsers()
        {
            using (var context = new GunStoreContext())
            {
                
                return View(context.Users.ToList());
            }
        }
        

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
        
        public ActionResult RemoveBaton(int? id)
        {
            using (var db = new GunStoreContext())
            {
                if (id != null)
                {
                    Baton baton = db.Batons.Include(b => b.BatonBaskets).Where(b => b.Id == id).Single<Baton>();
                    foreach (var item in baton.BatonBaskets)
                    {
                        db.BasketBatons.Remove(item);
                    }
                    db.Batons.Remove(baton);
                    db.SaveChanges();                    
                }
                
                List<Baton> batons = db.Batons.ToList();
                return View(batons);

            }
        }

        public ActionResult RemoveClothing(int? id)
        {
            using (var db = new GunStoreContext())
            {
                if (id != null)
                {
                    Clothing clothing = db.Clothes.Include(b => b.BasketClothings).Where(b => b.Id == id).Single<Clothing>();
                    foreach (var item in clothing.BasketClothings)
                    {
                        db.BasketClothings.Remove(item);
                    }
                    db.Clothes.Remove(clothing);
                    db.SaveChanges();
                }

                List<Clothing> clothings = db.Clothes.ToList();
                return View(clothings);

            }
        }


        public ActionResult RemoveFirearm(int? id)
        {
            using (var db = new GunStoreContext())
            {
                if (id != null)
                {
                    Firearm firearm = db.Firearms.Include(b => b.BasketFirearms).Where(b => b.Id == id).Single<Firearm>();
                    foreach (var item in firearm.BasketFirearms)
                    {
                        db.BasketFirearms.Remove(item);
                    }
                    db.Firearms.Remove(firearm);
                    db.SaveChanges();
                }

                List<Firearm> firearms = db.Firearms.ToList();
                return View(firearms);

            }
        }

        public ActionResult RemoveFlashlight(int? id)
        {
            using (var db = new GunStoreContext())
            {
                if (id != null)
                {
                    Flashlight flashlight = db.Flashlights.Include(b => b.BasketFlashlights).Where(b => b.Id == id).Single<Flashlight>();
                    foreach (var item in flashlight.BasketFlashlights)
                    {
                        db.BasketFlashlights.Remove(item);
                    }
                    db.Flashlights.Remove(flashlight);
                    db.SaveChanges();
                }

                List<Flashlight> flashlights = db.Flashlights.ToList();
                return View(flashlights);

            }
        }

        public ActionResult RemoveHolster(int? id)
        {
            using (var db = new GunStoreContext())
            {
                if (id != null)
                {
                    Holster holster = db.Holsters.Include(b => b.BasketHolsters).Where(b => b.Id == id).Single<Holster>();
                    foreach (var item in holster.BasketHolsters)
                    {
                        db.BasketHolsters.Remove(item);
                    }
                    db.Holsters.Remove(holster);
                    db.SaveChanges();
                }

                List<Holster> holsters = db.Holsters.ToList();
                return View(holsters);

            }
        }

        public ActionResult RemoveKnife(int? id)
        {
            using (var db = new GunStoreContext())
            {
                if (id != null)
                {
                    Knife knife = db.Knives.Include(b => b.BasketKnives).Where(b => b.Id == id).Single<Knife>();
                    foreach (var item in knife.BasketKnives)
                    {
                        db.BasketKnives.Remove(item);
                    }
                    db.Knives.Remove(knife);
                    db.SaveChanges();
                }

                List<Knife> knives = db.Knives.ToList();
                return View(knives);

            }
        }

        public ActionResult RemoveRound(int? id)
        {
            using (var db = new GunStoreContext())
            {
                if (id != null)
                {
                    Round round = db.Rounds.Include(b => b.BasketRounds).Where(b => b.Id == id).Single<Round>();
                    foreach (var item in round.BasketRounds)
                    {
                        db.BasketRounds.Remove(item);
                    }
                    db.Rounds.Remove(round);
                    db.SaveChanges();
                }

                List<Round> rounds = db.Rounds.ToList();
                return View(rounds);

            }
        }

        public ActionResult RemoveScope(int? id)
        {
            using (var db = new GunStoreContext())
            {
                if (id != null)
                {
                    Scope scope = db.Scopes.Include(b => b.BasketScopes).Where(b => b.Id == id).Single<Scope>();
                    foreach (var item in scope.BasketScopes)
                    {
                        db.BasketScopes.Remove(item);
                    }
                    db.Scopes.Remove(scope);
                    db.SaveChanges();
                }

                List<Scope> scopes = db.Scopes.ToList();
                return View(scopes);

            }
        }

        public ActionResult RemoveTazer(int? id)
        {
            using (var db = new GunStoreContext())
            {
                if (id != null)
                {
                    Tazer tazer = db.Tazers.Include(b => b.BasketTazers).Where(b => b.Id == id).Single<Tazer>();
                    foreach (var item in tazer.BasketTazers)
                    {
                        db.BasketTazers.Remove(item);
                    }
                    db.Tazers.Remove(tazer);
                    db.SaveChanges();
                }

                List<Tazer> tazers = db.Tazers.ToList();
                return View(tazers);

            }
        }
    }
}
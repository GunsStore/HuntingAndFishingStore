using Data;
using Models.Dtos;
using System.Linq;
using System.Web.Mvc;

namespace Application.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult ListFirearms (ProductDto model)
        {
            if (model.Name==null)
            {
                using (var context = new GunStoreContext())
                {
                    var products = context.Firearms.ToList();
                    return View(products);
                }
            }
            else
            {
                using (var context = new GunStoreContext())
                {
                    var products = context.Firearms.Where(f => f.Name.Contains(model.Name)).ToList();
                    return View(products);
                }
            }
            
        }

        public ActionResult ListClothing (ProductDto model)
        {
            if (model.Name == null)
            {
                using (var context = new GunStoreContext())
                {
                    var products = context.Clothes.ToList();
                    return View(products);
                }
            }
            else
            {
                using (var context = new GunStoreContext())
                {
                    var products = context.Clothes.Where(c => c.Name.Contains(model.Name)).ToList();
                    return View(products);
                }
            }
            
        }

        public ActionResult ListHolsters ()
        {
            using (var context = new GunStoreContext())
            {
                var products = context.Holsters.ToList();
                return View(products);
            }
        }

        public ActionResult ListScopes()
        {
            using (var context = new GunStoreContext())
            {
                var products = context.Scopes.ToList();
                return View(products);
            }
        }

        public ActionResult ListAmmunition()
        {
            using (var context = new GunStoreContext())
            {
                var products = context.Rounds.ToList();
                return View(products);
            }
        }

        public ActionResult ListKnives()
        {
            using (var context = new GunStoreContext())
            {
                var products = context.Knives.ToList();
                return View(products);
            }
        }

        public ActionResult ListTazers()
        {
            using (var context = new GunStoreContext())
            {
                var products = context.Tazers.ToList();
                return View(products);
            }
        }

        public ActionResult ListBatons()
        {
            using (var context = new GunStoreContext())
            {
                var products = context.Batons.ToList();
                return View(products);
            }
        }
    }
}
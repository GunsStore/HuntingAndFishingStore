using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        public ActionResult LoggedinUserIndex()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            ModelState.AddModelError("Error","Must be loggedin");
            return RedirectToAction("Login", "Account");
        }
    }
}
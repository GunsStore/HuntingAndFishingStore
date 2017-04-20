using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.Controllers
{
    public class ChartController : Controller
    {
        // GET: AddToChart
        [HttpGet]
        public ActionResult AddToChart()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddToChart(int id)
        {
            using (var db = new GunStoreContext())
            {
                return View();
            }
        } 
    }
}
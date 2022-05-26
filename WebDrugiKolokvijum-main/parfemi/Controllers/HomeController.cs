using parfemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace parfemi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Parfem> parfemi = (List<Parfem>)HttpContext.Application["parfemi"];
            if(parfemi.Count.Equals(0))
            {
                return RedirectToAction("Index","Unos");
            }
            return View(parfemi);
        }

        [HttpPost]
        public ActionResult Filter(int cena)
        {
            List<Parfem> parfemi = (List<Parfem>)HttpContext.Application["parfemi"];
            parfemi = parfemi.Where(parfem => parfem.Cena <= cena).ToList<Parfem>();
            return View("Index",parfemi);
        }
    }
}
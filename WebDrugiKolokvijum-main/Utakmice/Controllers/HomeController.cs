using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utakmice.Models;

namespace Utakmice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Utakmica> utakmice = (List<Utakmica>)HttpContext.Application["utakmice"];
            if (utakmice.Count.Equals(0))
            {
                return RedirectToAction("Index","Unos");
            }
            return View(utakmice);
        }

        [HttpPost]
        public ActionResult Filter(Liga liga)
        {
            List<Utakmica> utakmice = (List<Utakmica>)HttpContext.Application["utakmice"];
            utakmice = utakmice.Where(utakmica => utakmica.Liga.Equals(liga)).ToList<Utakmica>();


            return View("Index",utakmice);

        }

        [HttpPost]
        public ActionResult Delete(String Id)
        {
            List<Utakmica> utakmice = (List<Utakmica>)HttpContext.Application["utakmice"];
            Utakmica ut = utakmice.Find(u => u.Id == Id);
            utakmice.Remove(ut);
            return View("Index",utakmice);
        }
    }
}
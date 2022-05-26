using Lekovi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lekovi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Lek> lekovi = (List<Lek>)HttpContext.Application["lekovi"];
            if (lekovi.Count.Equals(0))
                return RedirectToAction("Index","Unos");
            return View(lekovi);
        }

        [HttpPost]
        public ActionResult Filter(int cena)
        {
            List<Lek> lekovi = (List<Lek>)HttpContext.Application["lekovi"];

            lekovi = lekovi.Where(l => l.Cena <= cena).ToList<Lek>();

            return View("Index", lekovi);
        
        }

        [HttpPost]
        public ActionResult Delete(String Id)
        {
            List<Lek> lekovi = (List<Lek>)HttpContext.Application["lekovi"];

            Lek le = lekovi.Find(l => l.Id == Id);
            lekovi.Remove(le);

            return RedirectToAction("Index","Novi");
        
        }
    }
}
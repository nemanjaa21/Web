using Lekovi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lekovi.Controllers
{
    public class UnosController : Controller
    {
        // GET: Unos
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Unesi(Lek lek,String NaAkciji)
        {

            List<Lek> lekovi = (List<Lek>)HttpContext.Application["lekovi"];
            if (NaAkciji == null)
                lek.NaAkciji = "Ne";
            else
                lek.NaAkciji = "Da";
            Lek le = lekovi.Find(l => l.Id == lek.Id );
            if (le == null)
                lekovi.Add(lek);
            else
                return RedirectToAction("Index","Greska");

            return RedirectToAction("Index","Home");

        
        }
      
    }
}
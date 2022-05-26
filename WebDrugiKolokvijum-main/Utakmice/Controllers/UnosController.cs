using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utakmice.Models;

namespace Utakmice.Controllers
{
    public class UnosController : Controller
    {
        // GET: Unos
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Unesi(Utakmica utakmica)
        {
            List<Utakmica> utakmice = (List<Utakmica>)HttpContext.Application["utakmice"];
            Utakmica ut = utakmice.Find(u => u.Id == utakmica.Id);
            if (ut == null)
            {
                utakmice.Add(utakmica);
            }
            else 
            {
                return RedirectToAction("Index","Greska");
            
            }
            return RedirectToAction("Index","Home");
        
        }
    }
}
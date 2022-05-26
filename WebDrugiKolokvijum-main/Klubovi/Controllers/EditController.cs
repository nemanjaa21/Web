using Klubovi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Klubovi.Controllers
{
    public class EditController : Controller
    {
        // GET: Edit
        public ActionResult Index()
        {
            List<Klub> klubovi = (List<Klub>)HttpContext.Application["klubovi"];
            if(klubovi.Count == 0)
                return RedirectToAction("Index", "Register");
            
            ViewBag.Klub = (Klub)Session["klub"];
            return View();
        }
        public ActionResult EditSetup(int id)
        {
            List<Klub> klubovi = (List<Klub>)HttpContext.Application["klubovi"];
            Klub klub = klubovi.Find(temp => temp.Id == id);
            Session["klub"] = klub;
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult DoEdit(Klub klub,string check)
        {
            List<Klub> klubovi = (List<Klub>)HttpContext.Application["klubovi"];
            Klub k = klubovi.Find(tmp => tmp.Id == klub.Id);

            if (check == null)
            {
                k.Aktivan = false;
            }
            else if (check.Equals("on"))
            {
                k.Aktivan = true;
            }
            k.Bodovi = klub.Bodovi;
            k.Id = klub.Id;
            k.Grad = klub.Grad;
            k.Naziv = klub.Naziv;

            return RedirectToAction("Index","Home");
        }
    }
}
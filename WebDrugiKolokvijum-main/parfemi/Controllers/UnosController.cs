using parfemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace parfemi.Controllers
{
    public class UnosController : Controller
    {
        // GET: Unos
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Unesi(Parfem parfem,string check)
        {
            List<Parfem> parfemi = (List<Parfem>)HttpContext.Application["parfemi"];
            if(check == null)
            {
                parfem.Akcija = false;
            }
            else
            {
                parfem.Akcija = true;
            }
            Parfem par = parfemi.Find(p => p.Id == parfem.Id);
            if(par == null)
            {
                parfemi.Add(parfem);
            }
            else
            {
                return RedirectToAction("Index", "Greska");
            }
            return RedirectToAction("Index","Home");
        }
    }
}
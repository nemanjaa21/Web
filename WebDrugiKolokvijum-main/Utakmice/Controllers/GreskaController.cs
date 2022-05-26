using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utakmice.Models;

namespace Utakmice.Controllers
{
    public class GreskaController : Controller
    {
        // GET: Greska
        public ActionResult Index()
        {
            List<Utakmica> utakmice = (List<Utakmica>)HttpContext.Application["utakmice"];
            if (utakmice.Count.Equals(0))
            {
                return RedirectToAction("Index","Unos");
            }
            return View();
        }
    }
}
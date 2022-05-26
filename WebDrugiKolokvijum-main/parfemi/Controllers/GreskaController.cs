using parfemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace parfemi.Controllers
{
    public class GreskaController : Controller
    {
        // GET: Greska
        public ActionResult Index()
        {
            List<Parfem> parfemi = (List<Parfem>)HttpContext.Application["parfemi"];
            if (parfemi.Count.Equals(0))
            {
                return RedirectToAction("Index", "Unos");
            }
            return View();
        }
    }
}
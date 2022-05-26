using Klubovi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Klubovi.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            if(Request.UserAgent.ToString().Equals("Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko"))
                return RedirectToAction("Index", "Explorer");
            return View();
        }

        [HttpPost]
        public ActionResult Register(Klub klub, string check)
        {
            List<Klub> klubovi = (List<Klub>)HttpContext.Application["klubovi"];

            if(check == null)
            {
                klub.Aktivan = false;
            }
            else if(check.Equals("on"))
            {
                klub.Aktivan = true;
            }
            klub.Id = ++Klub.id;
            klubovi.Add(klub);
            klub.Bodovi = 0;
            return RedirectToAction("Index", "Home");
        }
    }
}
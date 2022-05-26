using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Index()
        {
            ViewBag.Message = Session["msg"];
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            List<User> users = (List<User>)HttpContext.Application["users"];
            User user = users.Find(u => u.Username.Equals(username) && u.Password.Equals(password));
            if (user == null)
            {
                Session["msg"] = "Korisnik ne postoji!";
                return RedirectToAction("Index", "Authentication");
            }
            else
            {
                Session["user"] = user;
                Session["cart"] = new Dictionary<Product, int>();
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            List<User> users = (List<User>)HttpContext.Application["users"];
            User u = users.Find(temp => temp.Username.Equals(user.Username) && temp.Password.Equals(user.Password));
            if (u == null)
            {
                users.Add(user);
                Session["user"] = user;
                Session["cart"] = new Dictionary<Product, int>();
                return RedirectToAction("Index","Home");
            }
            else
            {
                return RedirectToAction("Register");
            }
        }

        public ActionResult Logout()
        {
            Session["user"] = null;
            Session["cart"] = null;
            return RedirectToAction("Index", "Authentication");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class AdministratorController : Controller
    {
        // GET: Administrator
        public ActionResult Index()
        {
            User user = (User)Session["user"];
            if (user == null)
                return RedirectToAction("Index", "Authentication");
            List<User> users = (List<User>)HttpContext.Application["users"];
            return View(users);
        }

        public ActionResult Remove(string username)
        {
            List<User> users = (List<User>)HttpContext.Application["users"];
            User us = (User)Session["user"];
            User user = users.Find(u => u.Username.Equals(username));
            if (!user.Equals(us))
            {
                users.Remove(user);
            }
            return RedirectToAction("Index");
        }
    }
}
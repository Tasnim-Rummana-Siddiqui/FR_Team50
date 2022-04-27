using Microsoft.AspNetCore.Mvc;
using FR_System.Models;
using System.Linq;
using System;
using Microsoft.AspNetCore.Http;

namespace FR_System.Controllers
{
    public class UserController : Controller
    {
        public ContextDB context;

        public UserController(ContextDB _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("u")))
                return View();

            else
                return RedirectToAction("Dashboard");
        }
        [HttpPost]
        public IActionResult Login(User ad)
        {
            var x = context.Users.Where(a => a.UserName == ad.UserName && a.Password == ad.Password).FirstOrDefault();

            if (x != null)
            {
                HttpContext.Session.SetString("u", ad.UserName);
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.m = "Wrong User ID or Password";
            }
            return View();
        }

        public IActionResult Dashboard()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("u")))
                return RedirectToAction("Login");
            else
                return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterPost(User user)
        {
            if (ModelState.IsValid)
            {
                if (user == null)
                {
                    return NoContent();
                }
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Register");
        }
    }
}

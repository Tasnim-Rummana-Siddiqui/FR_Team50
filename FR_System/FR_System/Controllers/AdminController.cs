﻿using Microsoft.AspNetCore.Mvc;
using FR_System.Models;
using System.Linq;
using System;
using Microsoft.AspNetCore.Http;

namespace FR_System.Controllers
{
    public class AdminController : Controller
    {
        public ContextDB context;

        public AdminController(ContextDB _context)
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
        public IActionResult Login(Admin ad)
        {
            var x = context.Admins.Where(a => a.AdminName == ad.AdminName && a.Password == ad.Password).FirstOrDefault();

            if (x != null)
            {
                HttpContext.Session.SetString("u", x.AdminName);
                HttpContext.Session.SetString("AID", x.AdminId.ToString());
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
            {
                int  id = int.Parse(HttpContext.Session.GetString("AID"));
               
                var admin = context.Admins.Find(id);
                if (admin == null)
                {
                    ViewBag.m = "ID or UserName not Matched";
                    return RedirectToAction("Login");
                }
                return View(admin);
            }
                
        }
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("u", String.Empty);
            HttpContext.Session.SetString("AID", String.Empty);
            return RedirectToAction("Login");
        }
    }
}

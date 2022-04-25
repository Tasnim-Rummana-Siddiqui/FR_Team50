using FR_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace FR_System.Controllers
{
    public class PlaneController : Controller
    {
        private readonly ContextDB _db;

        public PlaneController(ContextDB db)
        {
            _db = db;
        }
        public IActionResult Create()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("u")))
                return RedirectToAction("Login", "Admin");
            return View();
        }

        // POST-Create Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Plane plane)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("u")))
                return RedirectToAction("Login", "Admin");
            _db.Planes.Add(plane);
            _db.SaveChanges();
            return RedirectToAction("Details");
        }
        public IActionResult Details()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("u")))
                return RedirectToAction("Login", "Admin");
            IEnumerable<Plane> planeList = _db.Planes;
            return View(planeList);
        }
    }
}

using FR_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            return View();
        }

        // POST-Create Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Plane plane)
        {
            _db.Planes.Add(plane);
            _db.SaveChanges();
            return RedirectToAction("Details");
        }
        public IActionResult Details()
        {
            IEnumerable<Plane> planeList = _db.Planes;
            return View(planeList);
        }
    }
}

using FR_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FR_System.Controllers
{
    public class FlightController : Controller
    {
        private readonly ContextDB _db;

        public FlightController(ContextDB db)
        {
            _db = db;
        }
        // GET-Create Action
        public IActionResult Create()
        {
            return View();
        }

        // POST-Create Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Flight flight)
        {
            _db.Flights.Add(flight);
            _db.SaveChanges();
            return RedirectToAction("Details");
        }

        public IActionResult Details()
        {
            IEnumerable<Flight> flightList = _db.Flights;
            return View(flightList);
        }
        // GET - Delete Action
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var flight = _db.Flights.Find(id);
            if (flight == null)
            {
                return NotFound();
            }
            return View(flight);
        }

        // POST-Delete Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(Flight? f)
        {
            if (f == null)
            {
                return NotFound();
            }
            int id = f.FlightId;
            var flight = _db.Flights.Find(id);
            if (flight == null)
            {
                return NotFound();
            }

            _db.Flights.Remove(flight);
            _db.SaveChanges();
            return RedirectToAction("Details");
        }

        // GET - Update Action
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var flight = _db.Flights.Find(id);
            if (flight == null)
            {
                return NotFound();
            }
            return View(flight);
        }

        // POST-Delete Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePost(Flight? f)
        {
            if (f == null)
            {
                return NotFound();
            }
            _db.Flights.Update(f);
            _db.SaveChanges();
            return RedirectToAction("Details");
        }
    }
}

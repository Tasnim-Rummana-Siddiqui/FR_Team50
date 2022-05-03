using FR_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FR_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public ContextDB context;

        public HomeController(ILogger<HomeController> logger, ContextDB _context)
        {
            _logger = logger;
            context = _context;
        }

        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
                return View();
            return RedirectToAction("Dashboard","User");
        }

        public IActionResult Search()
        {
            ViewBag.dcity=context.Flights.Select(l=>l.FlightFrom).Distinct().ToList();
            ViewBag.acity = context.Flights.Select(l => l.FlightTo).Distinct().ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Searchpost(string cityfrom,string cityto,DateTime date1)
        {
            IEnumerable<Flight> flightList = context.Flights.Where(l => l.FlightFrom.Equals(cityfrom) && l.FlightTo.Equals(cityto) && l.FlightDDate.Equals(date1));

            if (string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
                return View(flightList);
            else
                return View("LoginSearch",flightList);
           
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

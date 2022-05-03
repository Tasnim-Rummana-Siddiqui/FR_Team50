using Microsoft.AspNetCore.Mvc;
using FR_System.Models;
using System.Linq;
using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace FR_System.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
               return RedirectToAction("Index", "Home");
            return View("BookingDetails");
        }

        public ContextDB context;

        public ReservationController(ContextDB _context)
        {
            context = _context;
        }
        public IActionResult Booking(int? id)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
                return RedirectToAction("Login","User");
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var flight = context.Flights.Find(id);
            if (flight == null)
            {
                return NotFound();
            }
            BookingViewModel bvm = new BookingViewModel
            {
                flights = flight,
                FlightId = flight.FlightId
            };
            return View(bvm);
        }

        [HttpPost]
        public IActionResult Booking(BookingViewModel bvm)
        {
            var flight = context.Flights.Find(bvm.FlightId);
            bvm.flights = flight;
            var ticket = new Reservation()
            {
                FlightId = bvm.FlightId,
                UserId = int.Parse(HttpContext.Session.GetString("userid")),
                Travellers = bvm.Travellers,
                Totalprice = bvm.Travellers * bvm.flights.Price,
                Payment = false
            };
            context.Reservations.Add(ticket);
            context.SaveChanges();
            bvm.Totalprice = ticket.Totalprice;
            return View("TicketView", bvm);
        }
        public IActionResult BookingDetails()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
                return RedirectToAction("Login","User");
            int id = int.Parse(HttpContext.Session.GetString("userid"));
            List<Reservation> reserve = context.Reservations.ToList();
            List<Flight> flig = context.Flights.ToList();
            List<User> users = context.Users.ToList();
            var usertickets = from r in reserve
                              where r.UserId == id
                              select new TicketViewModel
                              {
                                  flights = context.Flights.Find(r.FlightId),
                                  reservations = r,
                                  userid = id,
                              };
            return View(usertickets);
        }
        public IActionResult BookingDelete(int? id)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
                return RedirectToAction("Login", "User");
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var booking = context.Reservations.Find(id);
            if (booking == null)
            {
                return NotFound();
            }
            TicketViewModel ticket = new TicketViewModel
            {
                flights = context.Flights.Find(booking.FlightId),
                reservations = booking
            };
            return View(ticket);
        }

        // POST-Delete Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BookingDelete(int id)
        {
            var reserve = context.Reservations.Find(id);
            if (reserve == null)
            {
                return NotFound();
            }

            context.Reservations.Remove(reserve);
            context.SaveChanges();
            return RedirectToAction("BookingDetails");
        }

        // GET - Update Action
        public IActionResult BookingUpdate(int? id)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
                return RedirectToAction("Login", "User");
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var booking = context.Reservations.Find(id);
            if (booking == null)
            {
                return NotFound();
            }
            return View(booking);
        }

        // POST-Delete Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BookingUpdate(Reservation ticket)
        {
            if (ticket == null)
            {
                return NotFound();
            }
            var flights = context.Flights.Find(ticket.FlightId);
            ticket.Totalprice = flights.Price * ticket.Travellers;
            context.Reservations.Update(ticket);
            context.SaveChanges();
            return RedirectToAction("BookingDetails");
        }
    }
}

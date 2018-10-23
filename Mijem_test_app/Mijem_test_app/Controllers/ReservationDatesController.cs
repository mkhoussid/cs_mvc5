using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Mijem_test_app.Models;

namespace Mijem_test_app.Controllers
{
    public class ReservationDatesController : Controller
    {
        //instantiate db cursor
        private ApplicationDbContext _context;

        public ReservationDatesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: ReservationDates
        public ViewResult Index()
        {
            var reservations = _context.ReservationDates
                .Include(r => r.Reservation)
                .Include(r => r.Contact)
                .ToList();
            return View(reservations);
        }

        public ActionResult NewReservation()
        {
            return View();
        }

        public ActionResult EditReservation(int id)
        {
            return View();
        }
    }
}
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

        public ActionResult Proceed()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ConfirmLocation()
        {
            var locations = _context.Reservations.ToList();
            return View(locations);
        }

        //saves user if they do not exist
        [HttpPost]
        public ActionResult NewReservation(Contact user)
        {
            var _user = _context.Contacts.Single(c => c.ContactNumber == user.ContactNumber);
            if (_user == null)
            {
                _context.Contacts.Add(user);
                _context.SaveChanges();
            }
            return View(user);
        }

        //public ActionResult NewReservation()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult CreateReservation(ReservationDate reservation)
        //{
        //    _context.ReservationDates.Add(reservation);

        //}

        public ActionResult EditReservation(int id)
        {
            var reservation = _context.ReservationDates
                .Include(r => r.Reservation)
                .Include(r => r.Contact)
                .SingleOrDefault(r => r.Id == id);
            //in case user decides to manually change URL
            if (reservation == null)
                return HttpNotFound();
            return View();
        }
    }
}
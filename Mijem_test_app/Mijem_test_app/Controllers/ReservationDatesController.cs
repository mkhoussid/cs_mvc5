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
        public ViewResult Index(int page = 0)
        {
            var reservations = _context.ReservationDates
                .Include(r => r.Reservation)
                .Include(r => r.Contact)
                .ToList();
            
            const int PageSize = 6; // you can always do something more elegant to set this

            var count = reservations.Count();

            var data = reservations.Skip(page * PageSize).Take(PageSize).ToList();

            this.ViewBag.MaxPage = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);

            this.ViewBag.Page = page;

            return this.View(data);
            //return View(reservations);
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

        public ActionResult Save(Reservation reservation)
        {
            _context.Reservations.Add(reservation);

            _context.SaveChanges();

            return View("Index");
        }

        public ActionResult Update(ReservationDate reservation)
        {
            var _reservation = _context.ReservationDates
                .Include(r => r.Reservation)
                .Include(r => r.Contact)
                .SingleOrDefault(r => r.Id == reservation.Id);
            return Content("Passed");
        }

        public ActionResult Delete(ReservationDate reservation)
        {
            var _reservation = _context.ReservationDates
                .Include(r => r.Reservation)
                .Include(r => r.Contact)
                .SingleOrDefault(r => r.Id == reservation.Id);
            return Content("Passed");
        }

        //saves user if they do not exist
        [HttpPost]
        public ActionResult NewReservation(Contact user)
        {
            var _existingContacts = _context.Contacts.ToList();
            foreach (var contact in _existingContacts)
            {
                if (contact.ContactNumber == user.ContactNumber)
                {
                    return View(user);
                }
            }
            _context.Contacts.Add(user);
            _context.SaveChanges();
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

        [Route("ReservationDates/EditReservation/{id}")]
        public ActionResult EditReservation(int? id)
        {
            
            var reservation = _context.ReservationDates
                .Include(r => r.Reservation)
                .Include(r => r.Contact)
                .SingleOrDefault(r => r.Id == id);
            //in case user decides to manually change URL
            if (reservation == null || !id.HasValue)
                return HttpNotFound();
            return View(reservation);
        }
    }
}
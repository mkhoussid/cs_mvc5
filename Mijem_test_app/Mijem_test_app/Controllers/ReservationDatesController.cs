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
                .Where(r => r.Deleted == false)
                .Include(r => r.Reservation)
                .Include(r => r.Contact)
                .ToList();
            
            const int PageSize = 6;

            var count = reservations.Count();

            var data = reservations.Skip(page * PageSize).Take(PageSize).ToList();

            ViewBag.MaxPage = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);

            ViewBag.Page = page;

            return View(data);
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

        [HttpPost]
        public ActionResult Update(ReservationDate reservation)
        {
            var _reservation = _context.ReservationDates
                .Include(r => r.Reservation)
                .Include(r => r.Contact)
                .SingleOrDefault(r => r.Id == reservation.Id);

            _reservation.ReservedDate = reservation.ReservedDate;

            _reservation.InfoFromTextBox = reservation.InfoFromTextBox;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(ReservationDate reservation)
        {
            var _reservation = _context.ReservationDates
                .Include(r => r.Reservation)
                .Include(r => r.Contact)
                .SingleOrDefault(r => r.Id == reservation.Id);

            _reservation.Deleted = true;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public ActionResult UpdateOrAddContact(ReservationDate user)
        //{
        //    ViewBag.ContactID = user.Contact.Id;

        //    return View("NewReservation");
        //}
        //saves user if they do not exist
        [HttpPost]
        public ActionResult NewReservation(ReservationDate user)
        {
            var _existingContacts = _context.Contacts.ToList();

            foreach (var contact in _existingContacts)
            {
                if (contact.Id == ViewBag.ContactID)
                {
                    return View(contact);
                }
            }
            _context.ReservationDates.Add(user);

            _context.SaveChanges();

            return View(user);
        }

        [Route("ReservationDates/EditReservation/{id}")]
        public ActionResult EditReservation(int? id)
        {
            
            var reservation = _context.ReservationDates
                .Include(r => r.Reservation)
                .Include(r => r.Contact)
                .SingleOrDefault(r => r.Id == id);
            
            //ensure deleted reservations cannot be accessed
            if (reservation == null || !id.HasValue || reservation.Deleted == true)
                return HttpNotFound();

            return View(reservation);
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
    }
}
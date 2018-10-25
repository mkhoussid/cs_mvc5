using System;
using System.Linq;
using System.Web.Mvc;
using Mijem_test_app.Models;

namespace Mijem_test_app.Controllers
{
    public class ContactsController : Controller
    {
        private ApplicationDbContext _context;

        public ContactsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Contacts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UpdateOrAddContact(ReservationDate user)
        {
            var _user = _context.Contacts.ToList();

            foreach (var contact in _user)
            {
                if (contact.Id == user.Contact.Id)
                {
                    ViewBag.ContactID = user.Contact.Id;
                    return RedirectToAction("NewReservation", "ReservationDates");
                }
            }
            _context.ReservationDates.Add(user);

            _context.SaveChanges();

            return View(user);
        }
    }
}
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

        [HttpPost]
        public ActionResult UpdateOrAddContact(ReservationDate user)
        {
            var _user = _context.Contacts.ToList();

            TempData["ContactNumber"] = user.Contact.ContactNumber;

            foreach (var contact in _user)
            {
                if (contact.ContactNumber == user.Contact.ContactNumber)
                {
                    return RedirectToAction("NewReservation", "ReservationDates");
                }
            }
            _context.Contacts.Add(user.Contact);

            _context.SaveChanges();

            return RedirectToAction("NewReservation", "ReservationDates");
        }

        public ActionResult Index()
        {
            return RedirectToAction("Index", "ReservationDates");
        }

        [HttpPost]
        public JsonResult Index(string Prefix)
        {
            //Note : you can bind same list from database
            var contacts = _context.Contacts.ToList();

            var names = (from N in contacts
                         where N.Name.StartsWith(Prefix)
                         select new { N.Name });
            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mijem_test_app.Models;

namespace Mijem_test_app.Controllers
{
    public class ReservationsController : Controller
    {


        // GET: Reservations
        public ActionResult Index()
        {
            return View("Reservations");
        }

        public ActionResult NewReservation()
        {
            return Content("Create Reservation");
        }
    }
}
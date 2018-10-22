using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mijem_test_app.Models
{
 /*
     This model includes the location,
     the person who reserved it and
     FOR when they reserved it (not
     when they reserved it)
*/
    public class ReservationDate
    {
        //location
        public Reservation Reservation { get; set; }
        //contact
        public Contact Contact { get; set; }
        //date reserved for
        public DateTime ReservedDate { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mijem_test_app.Models
{
    [HandleError]
 /*
     This model includes the location,
     the person who reserved it and
     FOR when they reserved it (not
     when they reserved it)
*/
    public class ReservationDate
    {
        //key
        public int Id { get; set; }

        //location name
        [Required]
        public Reservation Reservation { get; set; }

        //contact
        [Required]
        public Contact Contact { get; set; }

        //date reserved for
        [Required]
        public DateTime ReservedDate { get; set; }

        //information from textbox
        [Required]
        public string InfoFromTextBox { get; set; }

        public bool Deleted { get; set; }
        
        public ImagesUploaded ImageURL { get; set; }
    }
}
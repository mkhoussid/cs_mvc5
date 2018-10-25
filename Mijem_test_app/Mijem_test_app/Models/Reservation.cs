using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mijem_test_app.Models
{
    [HandleError]
    public class Reservation
    {
        //unique ID of location
        public int Id { get; set; }
        //name of location
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        //because part of the Ask did not include authentication, I am hardcoding Favorites and Ranking
        public int Ranking { get; set; }
        public bool Favorites { get; set; }
        
    }
}
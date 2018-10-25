using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mijem_test_app.Models
{
    [HandleError]
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Contact Name ...")]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Contact Type")]
        public string ContactType { get; set; }
        [Required]
        [Display(Name = "Phone:")]
        public long ContactNumber { get; set; }
        [Column(TypeName = "date")]
        [Display(Name = "Birthdate")]
        public DateTime BirthDate { get; set; }
    }
}
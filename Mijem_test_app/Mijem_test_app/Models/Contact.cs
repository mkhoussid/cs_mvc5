using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mijem_test_app.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string ContactType { get; set; }
        [Required]
        public int ContactNumber { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
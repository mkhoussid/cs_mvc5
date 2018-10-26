using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mijem_test_app.Models
{
    public class ImagesUploaded
    {
        public int Id { get; set; }
        [Required]
        public string ImageURL { get; set; }
    }
}
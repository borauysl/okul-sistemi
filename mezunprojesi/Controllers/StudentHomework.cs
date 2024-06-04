using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mezunprojesi.Controllers
{
    public class StudentHomework
    {
        [Required]
        public int dersid {  get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string text { get; set; }

    }
}
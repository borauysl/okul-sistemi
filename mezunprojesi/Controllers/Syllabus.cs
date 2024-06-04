﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;

namespace mezunprojesi.Controllers
{
    public class Syllabus
    {
        [Required]
        public string dept { get; set; }

        [Required]
        public string coursename { get; set; }

        [Required]
        public string day { get; set; }

        [Required]
        public string time { get; set; }
    }
}
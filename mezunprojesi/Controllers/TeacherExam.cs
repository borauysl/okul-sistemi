using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;

namespace mezunprojesi.Controllers
{
    public class TeacherExam
    {
        [Required]
        public int lessonid { get; set; }

        [Required]
        public int userid { get; set; }

        [Required]
        public int midtermresult { get; set; }

        [Required]
        public int finalresult { get; set; }

        [Required]
        public string lessonname { get; set; }


    }
}
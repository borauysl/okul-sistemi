using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mezunprojesi.Controllers
{
    public class ExamSchedule
    {
        public int dersid { get; set; }
        public DateTime date { get; set; }
        public string classs { get; set; }
        public string lessonname { get; set; }
    }
}
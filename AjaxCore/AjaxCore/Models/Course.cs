using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxCore.Models
{
    public class Course
    {
        public string CourseNum { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int SemesterId { get; set; }
    }
}

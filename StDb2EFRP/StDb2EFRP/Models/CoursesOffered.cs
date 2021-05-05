using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace StDb2EFRP
{
    public partial class CoursesOffered
    {
        public string CourseNum { get; set; }
        public int? NumRegistered { get; set; }
        public int? Capacity { get; set; }

        public virtual Course CourseNumNavigation { get; set; }
    }
}

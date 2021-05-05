using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StDb2EFRP;

namespace StDb2EFRP.Pages.Enroll
{
    public class EnrollmModel : PageModel
    {
        private readonly StDb2EFRP.StDb2SqlContext _context;

        public EnrollmModel(StDb2EFRP.StDb2SqlContext context)
        {
            _context = context;
        }

        public IList<Enrollment> Enrollment { get;set; }

        public async Task OnGetAsync()
        {
            Enrollment = await _context.Enrollments
                .Include(e => e.CourseNumNavigation)
                .Include(e => e.Student).ToListAsync();
        }
    }
}

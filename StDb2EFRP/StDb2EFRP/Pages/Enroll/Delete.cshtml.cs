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
    public class DeleteModel : PageModel
    {
        private readonly StDb2EFRP.StDb2SqlContext _context;

        public DeleteModel(StDb2EFRP.StDb2SqlContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Enrollment Enrollment { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Enrollment = await _context.Enrollments
                .Include(e => e.CourseNumNavigation)
                .Include(e => e.Student).FirstOrDefaultAsync(m => m.CourseNum == id);

            if (Enrollment == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Enrollment = await _context.Enrollments.FindAsync(id);

            if (Enrollment != null)
            {
                _context.Enrollments.Remove(Enrollment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

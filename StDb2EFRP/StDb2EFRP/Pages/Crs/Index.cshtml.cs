using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StDb2EFRP;

namespace StDb2EFRP.Pages.Crs
{
    public class IndexModel : PageModel
    {
        private readonly StDb2EFRP.StDb2SqlContext _context;

        public IndexModel(StDb2EFRP.StDb2SqlContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Courses.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StDb2EFRP;

namespace StDb2EFRP.Pages.Stu
{
    public class IndexModel : PageModel
    {
        private readonly StDb2EFRP.StDb2SqlContext _context;

        public IndexModel(StDb2EFRP.StDb2SqlContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}

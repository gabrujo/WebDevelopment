using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StateManagement.Models;
using StateManagement.Utils;

namespace StateManagement.Pages
{
    public class SessionTestModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Student s1 = new Student { FirstName = "Bill", LastName = "Baker", Id = 1234 };
            HttpContext.Session.Set<Student>("studentinfokey", s1);
            Message = "Student data stored successfully in session";
        }
    }

}

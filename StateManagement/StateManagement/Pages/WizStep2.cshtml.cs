using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using StateManagement.Models;

namespace StateManagement.Pages
{
    public class WizStep2Model : PageModel
    {
        [BindProperty]
        public UserInfo UInfo { get; set; }
        [TempData]
        public string TempDataWiz { get; set; }
        public IActionResult OnGet()
        {
            if (TempDataWiz != null)
                UInfo = JsonConvert.DeserializeObject<UserInfo>(TempDataWiz);
            else
                return RedirectToPage("WizStep1");
            UInfo.Wizhidden = JsonConvert.SerializeObject(UInfo);
            return Page();
        }
        public IActionResult OnPostNextButton()
        {
            UserInfo uprev = null;
            if (UInfo.Wizhidden != null)
                //UInfo = JsonConvert.DeserializeObject<UserInfo>(UInfo.Wizhidden);
                uprev = JsonConvert.DeserializeObject<UserInfo>(UInfo.Wizhidden);
            else
                return RedirectToPage("WizStep1");
            ModelState.Remove("UInfo.FirstName");
            ModelState.Remove("UInfo.LastName");
            ModelState.Remove("UInfo.Email");
            ModelState.Remove("UInfo.Cellphone");
            ModelState.Remove("UInfo.Telephone");
            ModelState.Remove("UInfo.UserPin");
            var errors = ModelState.Where(x => x.Value.Errors.Count > 0).Select(x => new
            { x.Key, x.Value.Errors }).ToArray();
            if (ModelState.IsValid)
            {
                UInfo.FirstName = uprev.FirstName;
                UInfo.LastName = uprev.LastName;
                UInfo.Email = uprev.Email;
                UInfo.Wizhidden = "";
                TempDataWiz = JsonConvert.SerializeObject(UInfo);
                return RedirectToPage("WizStep3");
            }
            return Page();
        }
        public IActionResult OnPostPrevButton()
        {
            if (UInfo.Wizhidden != null)
                UInfo = JsonConvert.DeserializeObject<UserInfo>(UInfo.Wizhidden);
            else
                return RedirectToPage("WizStep1");
            UInfo.Wizhidden = "";
            TempDataWiz = JsonConvert.SerializeObject(UInfo);
            return RedirectToPage("WizStep1");
        }
    }

}

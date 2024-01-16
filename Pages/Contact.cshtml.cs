using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Customer
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public CustomerInfo CustomerInfo {set; get;}
        public void OnGet()
        {
        }
    }
}

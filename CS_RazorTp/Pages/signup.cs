using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class SignUpModel : PageModel
    {
        // Define the properties for the sign up model
        [BindProperty]
        [Required]
        public string Name { get; set; }

        [BindProperty]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [BindProperty]
        [Required]
        public string Address { get; set; }

        // Define the handler for the sign up action
        public async Task<IActionResult> OnPostAsync()
        {
            // Validate the model state
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // TODO: Implement the logic to sign up the user with the name, email, password and address
            // You can use the built-in ASP.NET Core Identity system or a custom authentication service
            // For example, you can use the UserManager<TUser> class to create a user with Identity
            // See https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity for more details

            // If the sign up is successful, redirect to the home page
            return RedirectToPage("/Index");
        }
    }
}

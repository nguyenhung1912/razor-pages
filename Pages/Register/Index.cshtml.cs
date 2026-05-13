using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pages.Models;

namespace razor_pages.Pages.Register
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public UserModel NewUser { get; set; } = default!;

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("/Success/Index");
        }
    }
}
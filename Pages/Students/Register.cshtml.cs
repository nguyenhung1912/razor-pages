using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pages.Models;
using razor_pages.Services;

namespace razor_pages.Pages.Students
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public StudentModel Student { get; set; } = default!;

        [BindProperty]
        public IFormFile? AvatarFile { get; set; }

        public bool IsRegistered { get; set; } = false;

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var uploadedAvatarUrl = DataService.UploadImage(AvatarFile, "uploads");
            if (uploadedAvatarUrl != null)
            {
                Student.AvatarPath = uploadedAvatarUrl;
            }

            IsRegistered = true;
            return Page();
        }
    }
}
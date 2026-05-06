// Create.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pages.Models;
using razor_pages.Services;

namespace razor_pages.Pages.Products
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Product InputProduct { get; set; } = default!;

        [BindProperty]
        public IFormFile? ImageFile { get; set; }

        public IActionResult OnPost()
        {
            var uploadedImageUrl = DataService.UploadImage(ImageFile);
            if (uploadedImageUrl != null)
            {
                InputProduct.ImageUrl = uploadedImageUrl;
            }

            DataService.Add(InputProduct);
            return RedirectToPage("./Index");
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pages.Models;
using razor_pages.Services;

namespace razor_pages.Pages.Products
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Product InputProduct { get; set; } = default!;

        [BindProperty]
        public IFormFile? ImageFile { get; set; }

        public IActionResult OnGet(int id)
        {
            var product = DataService.GetById(id);
            if (product == null) return NotFound();

            InputProduct = product;
            return Page();
        }

        public IActionResult OnPost()
        {
            var uploadedImageUrl = DataService.UploadImage(ImageFile);
            if (uploadedImageUrl != null)
            {
                InputProduct.ImageUrl = uploadedImageUrl;
            }

            DataService.Update(InputProduct);
            return RedirectToPage("./Index");
        }
    }
}
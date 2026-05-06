using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pages.Models;
using razor_pages.Services;

namespace razor_pages.Pages.Products
{
    public class DetailsModel : PageModel
    {
        public Product Product { get; set; } = default!;

        public IActionResult OnGet(int id)
        {
            var product = DataService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            Product = product;
            return Page();
        }
    }
}
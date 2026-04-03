using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pages.Models;
using razor_pages.Services.Products;

namespace razor_pages.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly IProductService _productService;

        public Product? Product { get; set; }

        public DetailsModel(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int id)
        {
            Product = _productService.GetProductById(id);

            if (Product == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
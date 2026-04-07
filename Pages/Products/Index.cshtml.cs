using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pages.Models;
using razor_pages.Services;
using razor_pages.Services.Products;

namespace razor_pages.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;

        public List<Product> Products { get; set; } = new List<Product>();

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public void OnGet()
        {
            Products = _productService.GetAllProducts();
        }
    }
}
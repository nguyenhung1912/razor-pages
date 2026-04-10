using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pages.Models;
using razor_pages.Services.Products;
namespace razor_pages.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public Product? SelectedProduct { get; set; }

        public void OnGet(int? id)
        {
            Products = _productService.GetAllProducts();

            if (id.HasValue)
            {
                SelectedProduct = _productService.GetProductById(id.Value);
            }
        }
    }
}
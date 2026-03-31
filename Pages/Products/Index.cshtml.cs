using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp.Namespace.Models;

namespace MyApp.Namespace.Pages.Products
{
    public class IndexModel : PageModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public Product? SelectedProduct { get; set; }

        public void OnGet(int? id)
        {
            Products = new List<Product>
            {
               new Product {Id = 1, Name = "Iphone", Price = 50000000, Description = "Iphone 15"},
               new Product {Id = 2, Name = "Samsung", Price = 20000000, Description = "Samsung ABC"},
               new Product {Id = 3, Name = "Oppo", Price = 5000000, Description = "Oppo ABC"},
               new Product {Id = 4, Name = "Google Pixel", Price = 10000000, Description = "Google Pixel ABC"},
            };

            if (id.HasValue) SelectedProduct = Products.FirstOrDefault(s => s.Id == id.Value);
        }
    }
}
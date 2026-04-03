using razor_pages.Models;
using razor_pages.Services.Products;

namespace razor_pages.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetAllProducts()
        {
            return new List<Product>
            {
               new Product {Id = 1, Name = "Iphone", Price = 50000000, Description = "Iphone 15"},
               new Product {Id = 2, Name = "Samsung", Price = 20000000, Description = "Samsung ABC"},
               new Product {Id = 3, Name = "Oppo", Price = 5000000, Description = "Oppo ABC"},
               new Product {Id = 4, Name = "Google Pixel", Price = 10000000, Description = "Google Pixel ABC"},
               new Product {Id = 5, Name = "Xiaomi", Price = 8000000, Description = "Xiaomi Note 12"}
            };
        }

        public Product? GetProductById(int id)
        {
            return GetAllProducts().FirstOrDefault(p => p.Id == id);
        }
    }
}
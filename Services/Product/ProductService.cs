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
              new Product { Id = 1, Name = "iPhone 13", Price = 20000000, Category = "Phone", Description = "Apple smartphone" },
              new Product { Id = 2, Name = "Samsung S23", Price = 18000000, Category = "Phone", Description = "Samsung smartphone" },
              new Product { Id = 3, Name = "Laptop Dell", Price = 15000000, Category = "Laptop", Description = "Dell laptop" },
              new Product { Id = 4, Name = "MacBook Pro", Price = 30000000, Category = "Laptop", Description = "Apple laptop" },
              new Product { Id = 5, Name = "Chuột Logitech", Price = 300000, Category = "Accessory", Description = "Chuột máy tính" },
              new Product { Id = 6, Name = "Bàn phím cơ", Price = 1000000, Category = "Accessory", Description = "Bàn phím gaming" }
            };
        }

        public Product? GetProductById(int id)
        {
            return GetAllProducts().FirstOrDefault(p => p.Id == id);
        }
    }
}
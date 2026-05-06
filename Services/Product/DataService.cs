using razor_pages.Models;
using Microsoft.AspNetCore.Http;

namespace razor_pages.Services
{
    public class DataService
    {
        public static List<Product> Products { get; set; } = new List<Product>
        {
            new Product { Id = 1, Name = "iPhone 13", Price = 20000000, Category = "Phone", Description = "Apple smartphone" },
            new Product { Id = 2, Name = "Laptop Dell Inspiron", Price = 15000000, Category = "Laptop", Description = "Dell office laptop" },
            new Product { Id = 3, Name = "Samsung Galaxy S22", Price = 18000000, Category = "Phone", Description = "Samsung flagship phone" },
            new Product { Id = 4, Name = "MacBook Air M2", Price = 28000000, Category = "Laptop", Description = "Apple lightweight laptop" },
            new Product { Id = 5, Name = "iPad Pro 11", Price = 22000000, Category = "Tablet", Description = "Apple tablet device" },
        };

        public static List<Product> GetAll() => Products;
        public static Product? GetById(int id) => Products.FirstOrDefault(p => p.Id == id);

        public static void Add(Product product)
        {
            product.Id = Products.Count > 0 ? Products.Max(p => p.Id) + 1 : 1;
            Products.Add(product);
        }

        public static void Update(Product updatedProduct)
        {
            var existing = GetById(updatedProduct.Id);
            if (existing != null)
            {
                existing.Name = updatedProduct.Name;
                existing.Price = updatedProduct.Price;
                existing.Category = updatedProduct.Category;
                existing.Description = updatedProduct.Description;
                if (!string.IsNullOrEmpty(updatedProduct.ImageUrl))
                    existing.ImageUrl = updatedProduct.ImageUrl;
            }
        }

        public static void Delete(int id)
        {
            var product = GetById(id);
            if (product != null) Products.Remove(product);
        }

        public static string? UploadImage(IFormFile? file, string folderName = "images")
        {
            if (file == null) return null;

            var uploads = Path.Combine("wwwroot", folderName);
            if (!Directory.Exists(uploads)) Directory.CreateDirectory(uploads);

            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var filePath = Path.Combine(uploads, fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return $"/{folderName}/" + fileName;
        }
    }
}
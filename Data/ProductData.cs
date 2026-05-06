using razor_pages.Models;

namespace razor_pages.Data
{
    public static class ProductData
    {
        public static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Description = "Laptop gaming", Price = 1200 },
            new Product { Id = 2, Name = "Smartphone", Description = "Điện thoại cao cấp", Price = 800 },
            new Product { Id = 3, Name = "Tablet", Description = "Máy tính bảng", Price = 500 }
        };
    }
}
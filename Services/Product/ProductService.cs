using razor_pages.Models;
using razor_pages.Services.Products;

namespace razor_pages.Services
{
    public class ProductService : IProductService
    {
        private List<Product> _products;
        public ProductService()
        {
            LoadAll();
        }
        public void LoadAll()
        {
            _products = new List<Product>
            {
              new Product { Id = 1, Name = "iPhone 13", Price = 20000000, Category = "Phone", Description = "Apple smartphone" },
              new Product { Id = 2, Name = "Samsung S23", Price = 18000000, Category = "Phone", Description = "Samsung smartphone" },
              new Product { Id = 3, Name = "Laptop Dell", Price = 15000000, Category = "Laptop", Description = "Dell laptop" },
              new Product { Id = 4, Name = "MacBook Pro", Price = 30000000, Category = "Laptop", Description = "Apple laptop" },
              new Product { Id = 5, Name = "Chuột Logitech", Price = 300000, Category = "Accessory", Description = "Chuột máy tính" },
              new Product { Id = 6, Name = "Bàn phím cơ", Price = 1000000, Category = "Accessory", Description = "Bàn phím gaming" }
            };
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> Search(string searchKeyWord)
        {
            if (string.IsNullOrWhiteSpace(searchKeyWord))
            {
                return _products;
            }
            return _products
                .Where(p => p.Name.ToLower().Contains(searchKeyWord.ToLower()))
                .ToList();
        }

        public void RemoveAll()
        {
            _products.Clear();
        }

        public void Add(Product product)
        {
            product.Id = _products.Count > 0 ? _products.Max(p => p.Id) + 1 : 1;
            _products.Add(product);
        }
    }
}
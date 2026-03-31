using Microsoft.AspNetCore.Mvc;
using razor_pages.Models;

namespace razor_pages.ViewComponents
{
    public class ProductList : ViewComponent
    {
        public IViewComponentResult Invoke(string sortOrder = "asc")
        {
            var products = new List<Product>
            {
               new Product {Id = 1, Name = "Iphone", Price = 50000000, Description = "Iphone 15"},
               new Product {Id = 2, Name = "Samsung", Price = 20000000, Description = "Samsung ABC"},
               new Product {Id = 3, Name = "Oppo", Price = 5000000, Description = "Oppo ABC"},
               new Product {Id = 4, Name = "Google Pixel", Price = 10000000, Description = "Google Pixel ABC"},
            };

            if (sortOrder.ToLower() == "desc")
            {
                products = products.OrderByDescending(p => p.Price).ToList();
            }
            else
            {
                products = products.OrderBy(p => p.Price).ToList();
            }

            return View(products);
        }
    }
}
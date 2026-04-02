using Microsoft.AspNetCore.Mvc;
using razor_pages.Models;

namespace razor_pages.Pages.Shared.Components.BestSellers
{
    public class BestSellers : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var allProducts = new List<Product>
            {
               new Product { Id = 1, Name = "Iphone", Price = 50000000, Description = "Iphone 15", SoldQuantity = 150},
               new Product { Id = 2, Name = "Samsung", Price = 20000000, Description = "Samsung ABC", SoldQuantity = 50},
               new Product { Id = 3, Name = "Oppo", Price = 5000000, Description = "Oppo ABC", SoldQuantity = 300},
               new Product { Id = 4, Name = "Google Pixel", Price = 10000000, Description = "Google Pixel", SoldQuantity = 120},
            };

            var bestSellers = allProducts.OrderByDescending(p => p.SoldQuantity).Take(2).ToList();

            return View(bestSellers);
        }

    }
}
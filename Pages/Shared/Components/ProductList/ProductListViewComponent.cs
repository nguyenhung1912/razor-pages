using Microsoft.AspNetCore.Mvc;
using razor_pages.Models;
using razor_pages.Services;
using razor_pages.Services.Products;

namespace razor_pages.ViewComponents
{
    public class ProductList : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductList(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(bool sortAsc = true, int quantity = 4)
        {
            var products = _productService.GetAllProducts();

            if (sortAsc)
            {
                products = products.OrderBy(p => p.Price).ToList();
            }
            else
            {
                products = products.OrderByDescending(p => p.Price).ToList();
            }

            if (quantity > 0)
            {
                products = products.Take(quantity).ToList();
            }

            return View(products);
        }
    }
}
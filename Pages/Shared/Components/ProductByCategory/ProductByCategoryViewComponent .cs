using Microsoft.AspNetCore.Mvc;

namespace razor_pages.ViewComponents
{
    public class ProductByCategoryViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string category)
        {
            var productData = new Dictionary<string, List<string>>
            {
                { "Electronics", new List<string> { "Laptop", "Smartphone", "Headphones" } },
                { "Books", new List<string> { "C# Programming", "ASP.NET Core Guide", "Design Patterns" } }
            };

            var products = new List<string>();

            if (!string.IsNullOrEmpty(category) && productData.ContainsKey(category))
            {
                products = productData[category];
            }

            ViewBag.CategoryName = category;

            return View(products);
        }
    }
}
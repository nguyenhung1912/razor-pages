using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pages.Models;
using razor_pages.Services;

namespace razor_pages.Pages.Products
{
    public class ListModel : PageModel
    {
        public List<Product> Products { get; set; } = default!;

        public void OnGet()
        {
            Products = DataService.GetAll();
        }
    }
}
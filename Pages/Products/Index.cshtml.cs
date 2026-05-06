using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pages.Models;
using razor_pages.Services;

namespace razor_pages.Pages.Products
{
    public class IndexModel : PageModel
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public Product? SelectedProduct { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchKeyWord { get; set; }

        public void OnGet(int? id)
        {
            if (!string.IsNullOrEmpty(SearchKeyWord))
            {
                Products = DataService.GetAll()
                    .Where(p => p.Name.ToLower().Contains(SearchKeyWord.ToLower()))
                    .ToList();
            }
            else
            {
                Products = DataService.GetAll();
            }

            if (id.HasValue)
            {
                SelectedProduct = DataService.GetById(id.Value);
            }
        }

        public IActionResult OnGetDelete(int id)
        {
            DataService.Delete(id);
            return RedirectToPage();
        }
    }
}
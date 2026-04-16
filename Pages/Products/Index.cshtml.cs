using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pages.Models;
using razor_pages.Services.Products;
namespace razor_pages.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public Product? SelectedProduct { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchKeyWord { get; set; }

        [BindProperty]
        public Product InputProduct { get; set; } = new Product();

        public void OnGet(int? id)
        {
            if (!string.IsNullOrEmpty(SearchKeyWord))
            {
                Products = _productService.Search(SearchKeyWord);
            }
            else
            {
                Products = _productService.GetAllProducts();
            }

            if (id.HasValue)
            {
                SelectedProduct = _productService.GetProductById(id.Value);
            }
        }

        public IActionResult OnGetRemoveAll()
        {
            _productService.RemoveAll();
            return RedirectToPage();
        }

        public IActionResult OnGetLoadAll()
        {
            _productService.LoadAll();
            return RedirectToPage();
        }

        public IActionResult OnPostCreate()
        {
            if (ModelState.IsValid)
            {
                _productService.Add(InputProduct);
            }
            return RedirectToPage();
        }
    }
}
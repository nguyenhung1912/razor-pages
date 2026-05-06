using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pages.Models;
using razor_pages.Services;

namespace razor_pages.Pages
{
    public class ProductPageModel : PageModel
    {
        public Product? product { get; set; }

        public void OnGet([FromQuery] int? id)
        {
            if (id != null)
            {
                ViewData["Title"] = $"Thông tin sản phẩm (ID={id.Value})";
                product = DataService.GetById(id.Value);
            }
            else
            {
                ViewData["Title"] = "Danh sách sản phẩm";
            }
        }
    }
}
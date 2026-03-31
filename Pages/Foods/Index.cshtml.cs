using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp.Namespace.Models;

namespace MyApp.Namespace.Pages.Foods
{
    public class IndexModel : PageModel
    {
        public List<Food> Dishes { get; set; } = new List<Food>();

        public void OnGet()
        {
            Dishes = new List<Food>
            {
                new Food{FoodName = "Cơm tấm"},
                new Food{FoodName = "Phở"},
                new Food{FoodName = "Bún bò Huế"}
            };
        }
    }
}
using razor_pages.Models;

namespace razor_pages.Services.Products
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
    }

}

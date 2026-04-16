using razor_pages.Models;

namespace razor_pages.Services.Products
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product? GetProductById(int id);
        List<Product> Search(string searchKeyWord);
        void RemoveAll();
        void LoadAll();
        void Add(Product product);
    }

}

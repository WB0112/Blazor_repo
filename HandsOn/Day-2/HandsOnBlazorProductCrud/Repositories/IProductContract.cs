using HandsOnBlazorProductCrud.Models;

namespace HandsOnBlazorProductCrud.Repositories
{
    public interface IProductContract
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}

using HandsOnBlazorProductCrud.Models;
using HandsOnBlazorProductCrud.Repositories;

namespace HandsOnBlazorProductCrud.Services
{
    public class ProductService
    {
        private readonly IProductContract productContract;
        public ProductService(IProductContract productContract)
        {
            this.productContract = productContract;
        }
        public void AddProduct(Product product)
        {
            productContract.Add(product);
        }
        public void UpdateProduct(Product product)
        {
            productContract.Update(product);
        }
        public void DeleteProduct(int id)
        {
            productContract.Delete(id);
        }
        public List<Product> GetAllProducts()
        {
            return productContract.GetProducts();
        }
        public Product GetProductById(int id)
        {
            return productContract.GetProduct(id);
        }

    }
}

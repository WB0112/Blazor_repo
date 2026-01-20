using ProductSelectedAndPlaceOrder.Models;

namespace ProductSelectedAndPlaceOrder.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
    }
}

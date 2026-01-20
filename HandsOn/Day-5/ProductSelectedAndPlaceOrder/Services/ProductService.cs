using ProductSelectedAndPlaceOrder.Models;

namespace ProductSelectedAndPlaceOrder.Services
{
    public class ProductService : IProductService
    {
        public async Task<List<Product>> GetProductsAsync()
        {
            await Task.Delay(500);
            return new List<Product>()
            {
                new(){Id=1,Name="Apple",Price=50},
                  new(){Id=2,Name="Orange",Price=70},
                    new(){Id=3,Name="Kiwi",Price=90},
            };
        }
    }
}

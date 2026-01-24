namespace Blazor.Web.Services
{
    public class ProductService:IProductService
    {
        public async Task<List<string>> GetProductsAsync()
        {
            // Simulate fetching product data
            var products = new List<string>
            {
                "Laptop",
                "Mouse",
                "Keyboard"
            };
            return await Task.FromResult(products);
        }
    }
}

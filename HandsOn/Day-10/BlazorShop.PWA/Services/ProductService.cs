using BlazorShop.PWA.Models;
namespace BlazorShop.PWA.Services;

public class ProductService
{
    public Task<List<Product>> GetProductsAsync()
    {
        return Task.FromResult(new List<Product>
{
new Product { Id = 1, Name = "Laptop", Price = 65000 },
new Product { Id = 2, Name = "Tablet", Price = 30000 },
new Product { Id = 3, Name = "Mobile", Price = 25000 }
});
    }
}
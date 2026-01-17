using ECommerceProductModule.Models;

namespace ECommerceProductModule.Services
{
    public class AppState
    {
        public List<Product> Products { get; set; } = new();
        public Product? SelectedProduct { get; set; }
        public event Action? OnChange;
        public void Load() // Simulate loading products from a data source
        {
            Products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99m },
                new Product { Id = 2, Name = "Smartphone", Price = 499.99m },
                new Product { Id = 3, Name = "Tablet", Price = 299.99m }
            };
            NotifyStateChanged();
        }
        public void Add(Product product)
        {
            product.Id = Products.Any() ? Products.Max(p => p.Id) + 1 : 1;
            Products.Add(product);
            NotifyStateChanged();
        }
        public void Update(Product product)
        {
            var existingProduct = Products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
            }
            NotifyStateChanged();
        }
        public void Delete(int productId)
        {
            var product = Products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                Products.Remove(product);
            }
            NotifyStateChanged();
        }
        public void Select(int id)
        {
            SelectedProduct = Products.FirstOrDefault(p => p.Id == id);
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

using HandsOnBlazorProductCrud.Models;

namespace HandsOnBlazorProductCrud.Repositories
{
    public class ProductRepository : IProductContract
    {
        private readonly List<Product> _products;
        public ProductRepository()
        {
                _products=new List<Product>();
        }
        public void Add(Product product)
        {
           _products.Add(product);
        }

        public void Delete(int id)
        {
           var product=_products.SingleOrDefault(p => p.Id == id); 
            _products.Remove(product);
        }

        public Product GetProduct(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public void Update(Product product)
        {
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Id== product.Id)
                {
                    _products[i].Price= product.Price;
                }
            }
        }
    }
}

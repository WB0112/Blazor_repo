using BlazorApp.Models;
using BlazorApp.Services.Interfaces;

namespace BlazorApp.Services
{
    public class CartService
    {
        private readonly IDiscountService _discountService;
        private readonly List<CartItem> _items = new();

        public CartService(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public void AddItem(CartItem item)
        {
            _items.Add(item);
        }

        public decimal GetTotal()
        {
            var subtotal = _items.Sum(i => i.Price * i.Quantity);
            return _discountService.ApplyDiscount(subtotal);
        }

        public IReadOnlyList<CartItem> GetItems() => _items;
    }

}

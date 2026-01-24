using BlazorApp.Services.Interfaces;

namespace BlazorApp.Services
{
    public class DiscountService : IDiscountService
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            if (totalAmount >= 500)
            {
                return totalAmount * 0.9m; // 10% discount
            }

            return totalAmount;
        }
    }

}

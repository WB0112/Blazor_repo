namespace BlazorApp.Services.Interfaces
{
    public interface IDiscountService
    {
        decimal ApplyDiscount(decimal totalAmount);
    }

}

using BlazorApp.Models;
using BlazorApp.Services;
using Xunit;

public class DiscountServiceTests
{
    private readonly DiscountService _service = new();

    [Fact]
    public void ApplyDiscount_WhenAmountBelow500_ReturnsSameAmount()
    {
        // Arrange
        var amount = 400m;

        // Act
        var result = _service.ApplyDiscount(amount);

        // Assert
        Assert.Equal(400m, result);
    }

    [Fact]
    public void ApplyDiscount_WhenAmountAbove500_Applies10PercentDiscount()
    {
        // Arrange
        var amount = 600m;

        // Act
        var result = _service.ApplyDiscount(amount);

        // Assert
        Assert.Equal(540m, result);
    }
    [Fact]
    public void GetTotal_Applies_Discount_When_Threshold_Reached()
    {
        // Arrange
        var discountService = new DiscountService();
        var cartService = new CartService(discountService);

        cartService.AddItem(new CartItem
        {
            Name = "Phone",
            Price = 600m,
            Quantity = 1
        });

        // Act
        var total = cartService.GetTotal();

        // Assert
        Assert.Equal(540m, total);
    }

}

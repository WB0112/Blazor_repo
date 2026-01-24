using BlazorApp.Models;
using BlazorApp.Services;
using BlazorApp.Tests;
using Xunit;

public class CartServiceTests
{
    [Fact]
    public void GetTotal_ReturnsCorrectSum_WithoutDiscount()
    {
        // Arrange
        var discountService = new FakeDiscountService();
        var cartService = new CartService(discountService);

        cartService.AddItem(new CartItem
        {
            Name = "Laptop",
            Price = 100m,
            Quantity = 2
        });

        cartService.AddItem(new CartItem
        {
            Name = "Mouse",
            Price = 50m,
            Quantity = 1
        });

        // Act
        var total = cartService.GetTotal();

        // Assert
        Assert.Equal(250m, total);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Bunit;
using Blazor.Web.Components;
using Moq;
using Blazor.Web.Services;
using Microsoft.Extensions.DependencyInjection;
namespace Blazor.Tests
{
    public class ProductListComponentTests:BunitContext
    {
        [Fact]
        public void ProductListRendersCorrectly()
        {

            //Act
            var cut = Render<ProductList>();
            //Assert
           Assert.Contains("Laptop", cut.Markup);// Example assertion
           Assert.Contains("Mouse", cut.Markup);// Example assertion
            //compare all products
            Assert.All(new[] { "Laptop", "Mouse", "Keyboard"}, product =>
            {
                Assert.Contains(product, cut.Markup);
            });
            //using Assert.True
              Assert.True(cut.Markup.Contains("Laptop") && cut.Markup.Contains("Keyboard") && cut.Markup.Contains("Mouse"));
        }
        [Fact]
        public void Products_Are_Rendered_From_Moq()
        {
            var mockService = new Mock<IProductService>(); // Mocking the service
            // Setup mock to return specific products
            mockService.Setup(service => service.GetProductsAsync()).ReturnsAsync(new List<string>
            {
                "Laptop",
                "Mouse"
            });
            Services.AddSingleton(mockService.Object); // Register mock service
            // Act
            var cut = Render<ProductList>();
            // Assert
            Assert.Contains("Laptop", cut.Markup);
            Assert.Contains("Mouse", cut.Markup);
        }
    }
}

using Bunit;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Blazor.Web.Components;
namespace Blazor.Tests
{
    public class CounterComponentWithServiceTests:BunitContext
    {
        [Fact]
        public void CounterComponentWithService_Increment_Works()
        {
            //Arrange
            Services.AddSingleton<Blazor.Web.Services.CounterService>();
            var cut=Render<CounterWithService>();
            //Act
            cut.Find("button").Click();
            //Assert
            Assert.Contains("1", cut.Markup);

        }
    }
}

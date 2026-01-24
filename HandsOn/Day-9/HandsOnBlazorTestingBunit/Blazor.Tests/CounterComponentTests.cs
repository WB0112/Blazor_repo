using System;
using System.Collections.Generic;
using System.Text;
using Bunit;
using Blazor.Web.Components.Pages;
namespace Blazor.Tests
{
    public class CounterComponentTests:BunitContext
    {
        [Fact]
        public void CounterStartsAtZero()
        {
            //Arrange
            string expectedMessage="Current count: 0";
            //Act
            var cut =Render<Counter>();
            //Assert
           // cut.Find("p").MarkupMatches($"<p>{expectedMessage}</p>");
            cut.Markup.Contains(expectedMessage);
            Assert.True(cut.Markup.Contains(expectedMessage));
        }
        [Fact]
        public void ClickingButtonIncrementsCounter()
        {
            //Arrange
            string expectedMessage="Current count: 1";
            var cut =Render<Counter>();
            //Act
            cut.Find("button").Click();
            //Assert
            cut.Markup.Contains(expectedMessage);
            Assert.True(cut.Markup.Contains(expectedMessage));
        }
    }
}

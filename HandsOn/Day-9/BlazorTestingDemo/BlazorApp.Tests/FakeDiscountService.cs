using BlazorApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Tests
{
    public class FakeDiscountService : IDiscountService
    {
        public decimal ApplyDiscount(decimal totalAmount)
            => totalAmount; // no discount for predictable testing
    }

}

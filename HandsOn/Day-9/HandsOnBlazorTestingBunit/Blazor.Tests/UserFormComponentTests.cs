using System;
using System.Collections.Generic;
using System.Text;
using Blazor.Web.Components;
using Bunit;
namespace Blazor.Tests
{
    public class UserFormComponentTests:BunitContext
    {
        [Fact]
        public void form_Submit_When_Valid()
        {
            var cut = Render<UserForm>();
            cut.Find("input").Change("John Doe");
            cut.Find("form").Submit();

        }
    }
}

using Bunit;
using System;
using System.Collections.Generic;
using System.Text;
using Blazor.Web.Components;
namespace Blazor.Tests
{
    public class LoginComponentTests:BunitContext
    {
        [Fact]
        public void LoginComponent_ShowValidattionErrors()
        {
            var cut = Render<Login>();
            cut.Find("button").Click();
            cut.Markup.Contains("required");
        }
    }
}

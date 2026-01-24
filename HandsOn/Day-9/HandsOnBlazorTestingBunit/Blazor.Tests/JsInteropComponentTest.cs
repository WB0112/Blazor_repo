using Bunit;
using System;
using System.Collections.Generic;
using System.Text;
using Blazor.Web.Components;
namespace Blazor.Tests
{
    public class JsInteropComponentTest:BunitContext
    {
        [Fact]
        public void AlertButton_Click_Invokes_JS_Alert()
        {
            //Arrange
            JSInterop.SetupVoid("alert", _ => true);//Mock JS alert
            var cut=Render<JsInterop>(); //Render component
            cut.Find("button").Click(); //Click button to invoke JS alert
            JSInterop.VerifyInvoke("alert"); //Verify JS alert was called
            //Act
            //Assert
        }
    }
}

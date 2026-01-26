using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PushNotificationService.Models;
using System.Text.Json;
using WebPush;

namespace PushNotificationService.Controllers
{
    [ApiController]
    [Route("api/push")]
    public class PushController : ControllerBase
    {
        private static PushSubscription _subscription;

        [HttpPost("subscribe")]
        public IActionResult Subscribe([FromBody] BrowserPushSubscription sub)
        {
            if (string.IsNullOrWhiteSpace(sub?.Endpoint))
                return BadRequest("Invalid subscription endpoint");

            // Save the subscription
            // In a real application, you would save this to a database
            // Here, we just store it in memory for demonstration purposes
            _subscription = new PushSubscription(
            sub.Endpoint,
            sub.Keys.P256dh,
            sub.Keys.Auth
            );


            return Ok("Subscription saved");
        }
        [HttpPost("send")]
        public IActionResult Send()
        {
            if (_subscription == null || string.IsNullOrWhiteSpace(_subscription.Endpoint))
                return BadRequest("No valid push subscription registered.");
            // VAPID keys should be generated and stored securely
            //What is VAPID: Voluntary Application Server Identification for Web Push protocol
            var vapidDetails = new VapidDetails(
                "mailto:test@demo.com",
              "BNP3R8YTFYIs9BEx6OzPFZkN8n3mVh5ccQMGimLlr5c7EB-Ph4HI0W8psD1WB8Fdq23zVDuEOzY8e2pN8fJg9ew",
                "MP6ZCCcom0kgDUwTgdrvXZzWViC3p4gfqGpqKT1WNvs"
            );

            var payload = JsonSerializer.Serialize(new
            {
                title = "Blazor PWA",
                message = "Push notification from ASP.NET Core"
            });

            var client = new WebPushClient();
            client.SendNotification(_subscription, payload, vapidDetails);

            return Ok("Push sent successfully");
        }


    }
}

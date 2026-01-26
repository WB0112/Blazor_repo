namespace PushNotificationService.Models
{
    public class PushSubscriptionModel
    {
        public string Endpoint { get; set; }
        public IDictionary<string, string> Keys { get; set; }
    }
}

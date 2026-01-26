namespace PushNotificationService.Models
{
    public class BrowserPushSubscription
    {
        public string Endpoint { get; set; }
        public BrowserPushKeys Keys { get; set; }
    }


    public class BrowserPushKeys
    {
        public string P256dh { get; set; }
        public string Auth { get; set; }
    }
}

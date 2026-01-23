using Microsoft.JSInterop;
namespace HandsOnBlazorJavascriptInterop.Interop
{
    public class JsInstanceCallbackService
    {
        public Action<string>? OnMessageReceived;
        [JSInvokable]
        public void Nofity(string message)
        {
            OnMessageReceived?.Invoke(message); //Invoke the event when a message is received from Javascript
        }
        [JSInvokable]
        public int Add(int a,int b)
        {
            return a + b;
        }
    }
}

using Microsoft.JSInterop;

namespace HandsOnBlazorJavascriptInterop.Interop
{
    public class JsStaticCallbacks
    {
        [JSInvokable] // Method callable from JavaScript
        public static void Notify(string message)
        {
            Console.WriteLine($"Notification from JavaScript: {message}");
        }
        [JSInvokable]
        public static int AddNumbers(int a,int b)
        {
            return a + b;
        }
        [JSInvokable]
        public static int Square(int a)
        {
            return a * a;
        }
    }
}

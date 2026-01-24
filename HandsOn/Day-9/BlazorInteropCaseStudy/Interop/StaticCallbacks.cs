namespace BlazorInteropCaseStudy.Interop
{
    using Microsoft.JSInterop;


    public static class StaticCallbacks
    {
        [JSInvokable]
        public static void Notify(string message)
        {
            Console.WriteLine($"JS says: {message}");
        }
    }

}

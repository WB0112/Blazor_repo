namespace HandsOnBlazorComponentDataCommunication.Components
{
    public class AppState
    {
        public string Message { get; set; } = "Hello from AppState!";
        public event Action? OnChange;
        public void setMessage(string message)
        {
            Message = message;
            OnChange?.Invoke();// Notify subscribers about the change
        }
    }
}

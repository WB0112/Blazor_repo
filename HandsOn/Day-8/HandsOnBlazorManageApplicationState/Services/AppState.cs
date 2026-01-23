namespace HandsOnBlazorManageApplicationState.Services
{
    public class AppState
    {
        public string? UserName { get; set; }
        public string? Role { get; set; }
        public event Action? OnChange;
        public void SetUser(string userName, string role)
        {
            UserName = userName;
            Role = role;
            NotifyStateChanged();
        }
        public void ClearUser()
        {
            UserName = null;
            Role = null;
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

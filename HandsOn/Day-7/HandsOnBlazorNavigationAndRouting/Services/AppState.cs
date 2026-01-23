namespace HandsOnBlazorNavigationAndRouting.Services
{
    public class AppState
    {
        public bool IsAdmin { get; set; } = false;
        public bool IsUser { get; set; } = false;
        public bool IsLoggedIn = false;
        public void Clear()
        {
            IsAdmin = false;
            IsUser = false;
            IsLoggedIn = false;
        }
    }
}

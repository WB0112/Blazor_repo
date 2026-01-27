namespace Blazor.Web.Models
{
    public class TokenResponse
    {
        public string Email { get; set; }
        public string Role { get; set; }
        public string Token { get; set; } = string.Empty;
    }
}

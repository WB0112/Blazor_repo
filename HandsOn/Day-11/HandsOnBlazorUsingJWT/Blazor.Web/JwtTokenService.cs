using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blazor.Web
{
    public class JwtTokenService
    {
        private readonly IJSRuntime _js;

        public JwtTokenService(IJSRuntime js)
        {
            _js = js;
        }
        // Store token in local storage
        public Task SetTokenAsync(string token) =>
            _js.InvokeVoidAsync("localStorage.setItem", "authToken", token).AsTask();
        // Retrieve token from local storage
        public Task<string?> GetTokenAsync() =>
            _js.InvokeAsync<string>("localStorage.getItem", "authToken").AsTask();
        // Remove token from local storage
        public Task RemoveTokenAsync() =>
            _js.InvokeVoidAsync("localStorage.removeItem", "authToken").AsTask();
    }
}

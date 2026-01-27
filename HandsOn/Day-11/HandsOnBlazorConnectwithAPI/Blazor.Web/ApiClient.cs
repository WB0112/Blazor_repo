using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace Blazor.Web
{


    public class ApiClient
    {
        private readonly HttpClient _http;
        private readonly JwtTokenService _tokenService;

        public ApiClient(HttpClient http, JwtTokenService tokenService)
        {
            _http = http;
            _tokenService = tokenService;
        }

        // Add Authorization header with Bearer token
        private async Task AddAuthorizationAsync()
        {
            var token = await _tokenService.GetTokenAsync();

            if (!string.IsNullOrWhiteSpace(token))
            {
                _http.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token);
            }
        }

        public async Task<T?> GetAsync<T>(string url)
        {
            await AddAuthorizationAsync();

            var response = await _http.GetAsync(url);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                throw new UnauthorizedAccessException("Unauthorized");

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<T>();
        }
        public async Task<TResponse?> PostAsync<TRequest, TResponse>(string url, TRequest data)
        {
            await AddAuthorizationAsync();
            var response = await _http.PostAsJsonAsync(url, data);
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                throw new UnauthorizedAccessException("Unauthorized");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<TResponse>();
        }
        //DELETE method
        public async Task DeleteAsync(string url)
        {
            await AddAuthorizationAsync();
            var response = await _http.DeleteAsync(url);
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                throw new UnauthorizedAccessException("Unauthorized");
            response.EnsureSuccessStatusCode();
        }
        //PUT method
        public async Task PutAsync<TRequest>(string url, TRequest data)
        {
            await AddAuthorizationAsync();
            var response = await _http.PutAsJsonAsync(url, data);
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                throw new UnauthorizedAccessException("Unauthorized");
            response.EnsureSuccessStatusCode();
        } 
        
        
    }
} 
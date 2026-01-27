using ProductAPI.Models;

namespace ProductAPI.Services
{
    public interface IUserService
    {
        Task<User?> AuthenticateAsync(string email, string password);

    }
}

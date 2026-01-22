using HandsOnBlazorNavigationAndRouting.Models;
using Microsoft.AspNetCore.SignalR.Protocol;
namespace HandsOnBlazorNavigationAndRouting.Services
{
    public class UserService
    {
        private readonly List<Models.User> _users = new()
        {
            new Models.User { Id = 1, Name = "Alice", Email = "alice@gmail.com", Role = "Admin", Password = "password1" },
            new Models.User { Id = 2, Name = "Bob", Email = "bob@gmail.com", Role = "User", Password = "password1" },
            new Models.User { Id = 3, Name = "Charlie", Email = "charlie@gmail.com", Role = "User", Password = "password1" }
        };
        public void Register(User user)
        {
            _users.Add(user);
        }
        public User? Authenticate(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
        public User? GetUser(string email)
        {
            return _users.FirstOrDefault(u => u.Email == email);
        }
        public List<User> GetUsers()
        {
            return _users;
        }   
    }
}

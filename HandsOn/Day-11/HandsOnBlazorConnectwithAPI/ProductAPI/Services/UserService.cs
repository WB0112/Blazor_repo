using Microsoft.EntityFrameworkCore;
using ProductAPI.DbAccess;
using ProductAPI.Models;
namespace ProductAPI.Services
{
    public class UserService:IUserService
    {
        private readonly AppDbContext _dbContext;
        public UserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<User?> AuthenticateAsync(string email, string password)
        {
            return _dbContext.Users
                .SingleOrDefaultAsync(u => u.Email == email && u.Password == password);
        }

    }
}

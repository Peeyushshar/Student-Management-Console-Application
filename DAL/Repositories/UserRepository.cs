using DAL.ApplicationDBContext;
using Microsoft.EntityFrameworkCore;
using static DAL.Entities.UserData;

namespace DAL.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository()
        {
            _context = new();
        }

        public async Task<List<Users>> GetAllAsync()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<bool> CheckEmailExistAsync(string? userEmail)
        {
            var checkEmail = await _context.Users.AnyAsync(x => x.Email == userEmail);
            return checkEmail;
        }

        public async Task<bool> CheckPasswordExistAsync(string? userEmail, string? userPassword)
        {
            var checkPassword = await _context.Users.AnyAsync(x => x.Email == userEmail && x.Password == userPassword);
            return checkPassword;
        }
    }
}

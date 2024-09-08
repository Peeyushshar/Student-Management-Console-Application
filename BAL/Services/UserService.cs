using BAL.DTOS;
using DAL.Repositories;

namespace BAL.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new();
        }

        public async Task<List<UserDto>> GetUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();

            var userDtos = users.Select(x => new UserDto()
            {
                Id = x.Id,
                Email = x.Email,
                Password = x.Password,
            }).ToList();

            return userDtos;
        }

        public async Task<bool> CheckEmail(string? EmailInput)
        {
            return await _userRepository.CheckEmailExistAsync(EmailInput);
        }

        public async Task<bool> CheckPassword(string? EmailInput, string? PasswordInput)
        {
            return await _userRepository.CheckPasswordExistAsync(EmailInput, PasswordInput);
        }
    }
}

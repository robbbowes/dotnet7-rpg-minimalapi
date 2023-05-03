using Domain.Models;

namespace Application.Abstractions
{
    public interface IAuthRepository
    {
        Task<ApiResponse<int>> Register(User user, string password);
        Task<ApiResponse<string>> Login(string username,  string password);
        Task<bool> UserExists(string username);
    }
}

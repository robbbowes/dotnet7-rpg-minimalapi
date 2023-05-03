using Domain.Models;
using MediatR;

namespace Application.Users.Commands
{
    public class LoginUser : IRequest<ApiResponse<string>>
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}

using Domain.Models;
using MediatR;

namespace Application.Users.Commands
{
    public class RegisterUser : IRequest<ApiResponse<int>>
    {
        public required string Username { get; set; }
        public string Password { get; set; } = string.Empty;
    }
}

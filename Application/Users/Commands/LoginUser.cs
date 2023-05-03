using Domain.Models;
using MediatR;

namespace Application.Users.Commands
{
    public class LoginUser : IRequest<ApiResponse<string>>
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}

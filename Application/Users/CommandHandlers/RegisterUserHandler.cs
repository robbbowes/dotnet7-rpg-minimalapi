using Application.Abstractions;
using Application.Users.Commands;
using Domain.Models;
using MediatR;

namespace Application.Users.CommandHandlers
{
    public class RegisterUserHandler : IRequestHandler<RegisterUser, ApiResponse<int>>
    {
        private readonly IAuthRepository _authRepo;

        public RegisterUserHandler(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        public async Task<ApiResponse<int>> Handle(RegisterUser request, CancellationToken cancellationToken)
        {
            var newUser = new User
            {
                Username = request.Username
            };

            return await _authRepo.Register(newUser, request.Password);
        }
    }
}

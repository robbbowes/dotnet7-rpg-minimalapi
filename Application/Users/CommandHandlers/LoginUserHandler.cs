using Application.Abstractions;
using Application.Users.Commands;
using Domain.Models;
using MediatR;

namespace Application.Users.CommandHandlers
{
    public class LoginUserHandler : IRequestHandler<LoginUser, ApiResponse<string>>
    {
        private readonly IAuthRepository _authRepo;

        public LoginUserHandler(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        public async Task<ApiResponse<string>> Handle(LoginUser request, CancellationToken cancellationToken)
        {
            return await _authRepo.Login(request.Username, request.Password);
        }
    }
}

using Application.Abstractions;
using Application.Users.Commands;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

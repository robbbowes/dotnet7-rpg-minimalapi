using Application.Users.Commands;
using Domain.Models;
using MediatR;
using MinimalApi.Abstractions;
using MinimalApi.DTOs.Users;

namespace MinimalApi.EndpointDefinitions
{
    public class AuthEndpointDefinition : IEndpointDefinition
    {
        public void RegisterEndpoints(WebApplication application)
        {
            var auth = application.MapGroup("/api/auth");

            auth.MapPost("/register", Register);
            auth.MapPost("/login", Login);
        }

        private async Task<IResult> Register(IMediator mediator, RegisterUser newUser)
        {
            var createdUser = await mediator.Send(newUser);
            return Results.Ok(createdUser);
        }

        private async Task<IResult> Login(IMediator mediator, LoginUser loginUser)
        {
            var loggedInUser = await mediator.Send(loginUser);
            return Results.Ok(loggedInUser);
        }
    }
}

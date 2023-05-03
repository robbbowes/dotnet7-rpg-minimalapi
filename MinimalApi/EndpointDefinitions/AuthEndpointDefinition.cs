using Application.Users.Commands;
using MediatR;
using MinimalApi.Abstractions;
using MinimalApi.Filters.Auth;

namespace MinimalApi.EndpointDefinitions
{
    public class AuthEndpointDefinition : IEndpointDefinition
    {
        public void RegisterEndpoints(WebApplication application)
        {
            var auth = application.MapGroup("/api/auth");

            auth.MapPost("/register", Register)
                .AddEndpointFilter<RegisterValidationFilter>();
            auth.MapPost("/login", Login)
                .AddEndpointFilter<LoginValidationFilter>();
        }

        private async Task<IResult> Register(IMediator mediator, RegisterUser newUser)
        {
            var response = await mediator.Send(newUser);
            if (!response.Success)
            {
                return Results.BadRequest(response);
            }
            return Results.Ok(response);
        }

        private async Task<IResult> Login(IMediator mediator, LoginUser loginUser)
        {
            var response = await mediator.Send(loginUser);
            if (!response.Success)
            {
                return Results.BadRequest(response);
            }
            return Results.Ok(response);
        }
    }
}

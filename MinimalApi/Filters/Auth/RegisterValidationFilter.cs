using Application.Users.Commands;
using Domain.Models;

namespace MinimalApi.Filters.Auth
{
    public class RegisterValidationFilter : IEndpointFilter
    {
        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            var argIndex = FilterValidationUtil.GetArgumentIndex(context.Arguments, typeof(RegisterUser));
            var registerUser = context.GetArgument<RegisterUser>(argIndex);
            if (string.IsNullOrEmpty(registerUser.Username) || string.IsNullOrEmpty(registerUser.Password))
            {
                var response = new ApiResponse<string>()
                {
                    Success = false,
                    Message = "Username and / or password invalid"
                };
                return await Task.FromResult(Results.BadRequest(response));
            }
            return await next(context);
        }
    }
}

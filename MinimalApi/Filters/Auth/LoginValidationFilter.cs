using Application.Users.Commands;
using Domain.Models;

namespace MinimalApi.Filters.Auth
{
    public class LoginValidationFilter : IEndpointFilter
    {
        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            var argIndex = FilterValidationUtil.GetArgumentIndex(context.Arguments, typeof(LoginUser));
            var loginUser = context.GetArgument<LoginUser>(argIndex);
            if (string.IsNullOrEmpty(loginUser.Username) || string.IsNullOrEmpty(loginUser.Password))
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

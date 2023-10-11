using Application.Services;

namespace API.Endpoints
{
    public static class UserEndpoints
    {
        public static void MapUserEndpoints(this IEndpointRouteBuilder app) 
        {
            app.MapPost("api/users", async (CreateUserRequest request, UserService userService) =>
            {
                var userId = await userService.CreateAsync(
                    request.Name,
                    request.Email);

                return Results.Ok(userId);
            });
        }
    }
}

using Application.Services;
using Domain.Entities;

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

            app.MapPut("api/users/{id}", async (Guid id, User request, UserService userService) => 
            {
                if (id != request.Id)
                    return Results.BadRequest();

                await userService.UpdateUserAsync(id, request);

                return Results.NoContent();
            });
        }
    }
}

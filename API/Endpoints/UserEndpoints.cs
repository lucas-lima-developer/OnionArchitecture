using Application.Queries;
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

            app.MapDelete("api/users/{id}", async (Guid id, UserService userService) =>
            {
                await userService.DelteUserAsync(id);

                return Results.NoContent();
            });

            app.MapGet("api/users/{id}", async (Guid id, IGetUserByIdQueryHandler handle) =>
            {
                var user = await handle.Handle(id);

                return user is null ? Results.NoContent() : Results.Ok(user);
            });

            app.MapGet("api/users", async (IGetUsersQueryHandler handle) =>
            {
                var users = await handle.Handle();

                return users is null ? Results.NoContent() : Results.Ok(users);
            });
        }
    }
}

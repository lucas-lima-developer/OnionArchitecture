using Application.Queries;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Queries
{
    public class GetUsersQueryHandler : IGetUsersQueryHandler
    {
        private readonly AppDbContext _context;

        public GetUsersQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserResponse>> Handle()
        {
            var users = await _context.Users.AsNoTracking()
                .Select(user => new UserResponse
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email
                })
                .ToListAsync();

            return users;
        }
    }
}

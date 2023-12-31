﻿using Application.Queries;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Queries
{
    public class GetUserByIdQueryHandler : IGetUserByIdQueryHandler
    {
        private readonly AppDbContext _context;

        public GetUserByIdQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<UserResponse?> Handle(Guid id)
        {
            var userResponse = await _context
                .Users
                .AsNoTracking()
                .Where(user => user.Id == id)
                .Select(user => new UserResponse
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email
                })
                .FirstOrDefaultAsync();

            return userResponse;
        }
    }
}

namespace Application.Queries
{
    public interface IGetUserByIdQueryHandler
    {
        Task<UserResponse?> Handler(Guid id);
    }
}

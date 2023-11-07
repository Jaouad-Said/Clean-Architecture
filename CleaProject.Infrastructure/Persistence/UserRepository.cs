using CleanProject.Application.Common.interfaces.Persistence;
using CleanProject.Domain.Entities;

namespace CleanProject.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _user = new();

    public void Add(User user)
    {
        _user.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
        return _user.SingleOrDefault(u => u.Email == email);
    }
}
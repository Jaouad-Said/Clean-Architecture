using CleanProject.Domain.Entities;

namespace CleanProject.Application.Common.interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}
using CleanProject.Domain.Entities;

namespace CleanProject.Application.Common.interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
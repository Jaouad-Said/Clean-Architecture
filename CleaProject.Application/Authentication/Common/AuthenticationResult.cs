using CleanProject.Domain.Entities;

namespace CleaProject.Application.Authentication.Common;
public record AuthenticationResult
(
    User User,
    string Token
);
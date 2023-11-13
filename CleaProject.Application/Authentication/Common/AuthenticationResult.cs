using CleanProject.Domain.Entities;

namespace CleanProject.Application.Authentication.Common;
public record AuthenticationResult
(
    User User,
    string Token
);
using CleanProject.Domain.Entities;

namespace CleanProject.Application.Services.Authentication;
public record AuthenticationResult
(
    User user,
    string Token
);
using CleanProject.Domain.Entities;

namespace CleanProject.Application.Services.Authentication.Common;
public record AuthenticationResult
(
    User user,
    string Token
);
using CleanProject.Application.Services.Authentication.Common;
using ErrorOr;

namespace CleanProject.Application.Services.Authentication.Queries;

public interface IAuthenticationQueryService
{
    ErrorOr<AuthenticationResult> Login(string email, string password);
}
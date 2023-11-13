using CleaProject.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace CleanProject.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password
) : IRequest<ErrorOr<AuthenticationResult>>;
using CleanProject.Application.Authentication.Commands.Register;
using CleanProject.Application.Authentication.Common;
using CleanProject.Application.Authentication.Queries.Login;
using CleanProject.Contracts.Authentication;
using Mapster;

namespace CleanProject.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();

        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
        .Map(dest => dest, src => src.User);
    }
}
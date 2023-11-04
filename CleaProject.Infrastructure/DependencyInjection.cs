using CleanProject.Application.Common.interfaces.Authentication;
using CleanProject.Application.Common.interfaces.Services;
using CleanProject.Infrastructure.Authentication;
using CleanProject.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CleanProject.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}
using CleanProject.Application.Common.interfaces.Authentication;
using CleanProject.Application.Common.interfaces.Persistence;
using CleanProject.Application.Common.interfaces.Services;
using CleanProject.Infrastructure.Authentication;
using CleanProject.Infrastructure.Persistence;
using CleanProject.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanProject.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}
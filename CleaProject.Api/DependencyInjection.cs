using CleanProject.Api.Common.Errors;
using CleanProject.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace CleanProject.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, CleanProjectProblemDetailsFactory>();
        services.AddMappings();
        return services;
    }
}
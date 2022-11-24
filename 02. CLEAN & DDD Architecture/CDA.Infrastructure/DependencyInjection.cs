using CDA.Application.Common.Interfaces.Authentication;
using CDA.Application.Common.Interfaces.Services;
using CDA.Infrastructure.Authentication;
using CDA.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CDA.Infrastructure;

public static class DependencyInjection 
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration) 
    {
        services.Configure<JwtSettings>(configuration.GetSection(nameof(JwtSettings)));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}
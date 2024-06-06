using BluperDinner.Aplication.Interfaces.Authentication;
using BluperDinner.Aplication.Interfaces.Persistence;
using BluperDinner.Aplication.Interfaces.Services;
using BluperDinner.Infrastructure.Authentication;
using BluperDinner.Infrastructure.Persistence;
using BluperDinner.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BluperDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator,JwTokenGenerator>();
        services.AddSingleton<IDateTimerProvider,DateTimeProvider>();

        services.AddScoped<IUserRepository,UserRepository>();
        return services;
    }

}
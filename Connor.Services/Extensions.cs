using Connor.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Connor.Services;

public static class Extensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IConnorService, ConnorService>();
        return services;
    }
}
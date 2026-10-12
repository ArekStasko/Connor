using Connor.Persistance.Repositories.Connor;
using Connor.Persistance.Repositories.Prompt;
using Connor.Persistance.Repositories.Receiver;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Connor.Persistance;

public static class Extensions
{
    public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<PersistanceContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(PersistanceContext).Assembly.FullName)));
        services.AddScoped<IConnorRepository, ConnorRepository>();
        services.AddScoped<IPromptRepository, PromptRepository>();
        services.AddScoped<IReceiverRepository, ReceiverRepository>();

        return services;
    }
}
using Connor.WebModel.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Connor.WebModel;

public static class Extensions
{
    public static void ConfigureModelProvider(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddScoped<IModelProvider, ModelProvider>();
    }
}
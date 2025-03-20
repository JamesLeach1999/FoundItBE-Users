using FoundItBE_Users.BusinessLayer;

namespace FoundItBE_Users.Domain;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDomainLayer(this IServiceCollection services)
    {
        services.AddTransient<IPostGresRepository, PostGresRepository>();

        return services;
    }
}

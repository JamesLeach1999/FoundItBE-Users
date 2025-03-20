namespace FoundItBE_Users.Domain;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDomainLayer(this IServiceCollection services)
    {
        services.AddSingleton<IPostGresRepository, PostGresRepository>();

        return services;
    }
}

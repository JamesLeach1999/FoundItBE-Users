using FluentValidation;
using FoundItBE_Users.Models;

namespace FoundItBE_Users.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IPostGresqlClient, PostGresqlClient>();

        return services;
    }
}

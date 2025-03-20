namespace FoundItBE_Users.BusinessLayer;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBusinessLayer(this IServiceCollection services)
    {
        services.AddTransient<ICreateNewUser, CreateNewUser>();

        return services;
    }
}

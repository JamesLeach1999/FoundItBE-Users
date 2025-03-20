using FluentValidation;
using FoundItBE_Users.Models;

namespace FoundItBE_Users.Validation;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddValidation(this IServiceCollection services)
    {
        services.AddTransient<AbstractValidator<UserReq>, UserReqValidator>();
        services.AddTransient<AbstractValidator<UserCredentials>, UserCredentialsValidator>();

        return services;
    }
}

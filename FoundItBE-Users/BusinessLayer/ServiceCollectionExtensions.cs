﻿using FoundItBE_Users.Domain;

namespace FoundItBE_Users.BusinessLayer;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBusinessLayer(this IServiceCollection services)
    {
        services.AddSingleton<IUserService, UserService>();
        services.AddSingleton<IUserLoginRateLimitService, UserLoginRateLimitService>();

        return services;
    }
}

using FoundItBE_Users.Models;
using Microsoft.Extensions.Caching.Memory;

namespace FoundItBE_Users.BusinessLayer;

public class UserLoginRateLimitService(IMemoryCache cacheService) : IUserLoginRateLimitService
{
    private readonly TimeSpan expiration = TimeSpan.FromMinutes(10);
    private const int MaxAttempts = 5;

    public void UpdateUserAttempts(string hashedUsername)
    {
        if(!cacheService.TryGetValue(hashedUsername, out int userAttempts)) 
        {
            cacheService.Set<int>(hashedUsername, 1, expiration);
            return;
        };

        cacheService.Set(hashedUsername, userAttempts + 1, expiration);
    }
}

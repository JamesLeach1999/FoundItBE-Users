using FoundItBE_Users.Models;
using Microsoft.Extensions.Caching.Memory;

namespace FoundItBE_Users.BusinessLayer;

public class UserThrottlingService(IMemoryCache cacheService) : IUserThrottlingService
{
    public bool CheckUserAttempts(string hashedUsername)
    {
        InitUserAttempts(hashedUsername);

        if(cacheService.Get<int>(hashedUsername) > 4)
        {
            return false;
        }

        return true;
    }

    public void InitUserAttempts(string hashedUsername)
    {
        cacheService.GetOrCreate(hashedUsername, cacheEntry =>
        {
            cacheEntry.Value = 1;
            return cacheEntry;
        });
    }

    public void UpdateUserAttempts(string hashedUsername)
    {
        if (cacheService.TryGetValue(hashedUsername, out var cacheEntry)) {
            cacheService.Set(hashedUsername, (int)cacheEntry + 1);
        }

        return;
    }
}

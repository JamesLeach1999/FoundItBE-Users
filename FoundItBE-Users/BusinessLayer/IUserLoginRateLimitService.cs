using FoundItBE_Users.Models;

namespace FoundItBE_Users.BusinessLayer;

public interface IUserLoginRateLimitService
{
    void UpdateUserAttempts(string hashedUsername);
}

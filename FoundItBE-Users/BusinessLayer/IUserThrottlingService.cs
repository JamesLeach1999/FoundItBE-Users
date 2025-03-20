using FoundItBE_Users.Models;

namespace FoundItBE_Users.BusinessLayer;

public interface IUserThrottlingService
{
    bool CheckUserAttempts(string hashedUsername);

    void InitUserAttempts(string hashedUsername);

    void UpdateUserAttempts(string hashedUsername);
}

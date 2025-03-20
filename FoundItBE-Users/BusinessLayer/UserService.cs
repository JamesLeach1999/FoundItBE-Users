using FoundItBE_Users.Models;

namespace FoundItBE_Users.BusinessLayer;

public class UserService(IUserThrottlingService userThrottlingService) : IUserService
{
    public Task GetUser(UserCredentials userCredentials)
    {
        throw new NotImplementedException();
    }
}

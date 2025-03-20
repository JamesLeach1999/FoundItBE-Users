using FoundItBE_Users.Domain;
using FoundItBE_Users.Models;

namespace FoundItBE_Users.BusinessLayer;

public class UserService(IUserLoginRateLimitService userLoginRateLimitService, IPostGresRepository postGresRepository) : IUserService
{
    public Task GetUser(UserCredentials userCredentials)
    {
        if(!userLoginRateLimitService.CheckUserAttempts(userCredentials.UserName))
        {
            Console.WriteLine("Error");
            return Task.CompletedTask;
        }
        return Task.CompletedTask;
    }
}

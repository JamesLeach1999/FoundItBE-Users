using FoundItBE_Users.Models;

namespace FoundItBE_Users.BusinessLayer;

public interface IUserService
{
    Task GetUser(UserCredentials userCredentials);
}

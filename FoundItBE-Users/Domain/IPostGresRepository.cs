using FoundItBE_Users.Models;

namespace FoundItBE_Users.Domain;

public interface IPostGresRepository
{
    Task CreateUser(UserReq user);
    Task<User> GetUserFromDatabase(string username);
}

using FoundItBE_Users.Models;

namespace FoundItBE_Users.Domain;

public interface ICreateNewUser
{
    Task CreateUser(UserReq req);
}

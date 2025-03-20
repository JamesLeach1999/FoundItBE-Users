using FoundItBE_Users.Models;

namespace FoundItBE_Users.BusinessLayer;

public interface ICreateNewUser
{
    Task CreateUser(UserReq req);
}

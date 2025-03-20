using FoundItBE_Users.Infrastructure;
using FoundItBE_Users.Models;
using Dapper;
using Npgsql;

namespace FoundItBE_Users.BusinessLayer;

public class CreateNewUser(IPostGresqlClient _postGresqlClient) : ICreateNewUser
{
    private readonly NpgsqlConnection _postGresqlCommand = _postGresqlClient.CreateConnection();
    public async Task CreateUser(UserReq req)
    {
        try
        {
            var newUserReq = new
            {
                username = req.UserName,
                password = req.Password,
                email = req.Email
            };

            await _postGresqlCommand.ExecuteAsync(Consts.InsertUser, newUserReq);
        }
        catch (Exception)
        {

            throw;
        }
    }
}

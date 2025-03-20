using Dapper;
using FoundItBE_Users.Infrastructure;
using FoundItBE_Users.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Npgsql;

namespace FoundItBE_Users.Domain;

public class PostGresRepository : IPostGresRepository
{
    private readonly NpgsqlConnection postGresqlCommand;

    public PostGresRepository(IPostGresqlClient postGresqlClient)
    {
        postGresqlCommand = postGresqlClient.CreateConnection();
    }
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

            await postGresqlCommand.ExecuteAsync(Consts.InsertUser, newUserReq);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<User> GetUserFromDatabase(string username)
    {
        try
        {
            var users = await postGresqlCommand.QueryAsync<User>(Consts.GetUserByUsername, username);

            var userList = users.ToList();


            if( userList is { Count: 0 })
            {
                return null;
            }

            return userList.FirstOrDefault();
        }
        catch (Exception)
        {

            throw;
        }
    }
}

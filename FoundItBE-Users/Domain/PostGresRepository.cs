
using FoundItBE_Users.Infrastructure;
using Npgsql;

namespace FoundItBE_Users.Domain;

public class PostGresRepository : IPostGresRepository
{
    private readonly NpgsqlConnection pgsqlConnection;
    public PostGresRepository(IPostGresqlClient postGresqlClient)
    {
        pgsqlConnection = postGresqlClient.CreateConnection();
    }
    public async Task GetUserFromDatabase(string username, string password)
    {
        


    }
}

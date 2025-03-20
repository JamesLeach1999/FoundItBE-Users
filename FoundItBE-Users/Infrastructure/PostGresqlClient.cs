using FoundItBE_Users.Infrastructure.Options;
using Microsoft.Extensions.Options;
using Npgsql;

namespace FoundItBE_Users.Infrastructure;

public sealed class PostGresqlClient(IOptions<PostGresqlConnectionOptions> _configuration) : IPostGresqlClient
{
    public NpgsqlConnection CreateConnection()
    {
        try
        {
            var connectionString = new NpgsqlConnectionStringBuilder
            {
                Host = _configuration.Value.Server,
                Username = _configuration.Value.UserId,
                Password = _configuration.Value.Password,
                Port = _configuration.Value.Port,
                Database = _configuration.Value.Database,
            };

            var connection = new NpgsqlConnection(connectionString.ConnectionString);

            return connection;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }
}

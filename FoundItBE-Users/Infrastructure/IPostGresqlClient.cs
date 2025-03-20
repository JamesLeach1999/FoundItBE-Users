using Npgsql;

namespace FoundItBE_Users.Infrastructure;

public interface IPostGresqlClient
{
    NpgsqlConnection CreateConnection();
}

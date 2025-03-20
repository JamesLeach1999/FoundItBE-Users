using System.Text.Json.Serialization;

namespace FoundItBE_Users.Infrastructure.Options;

public class PostGresqlConnectionOptions
{
    public const string PostGresqlOptionsKey = "PostGresqlConnection";

    public string Server { get; set; }

    public string Database { get; set; }

    public int Port { get; set; }

    [JsonPropertyName("User Id")]
    public string UserId { get; set; }

    public string Password { get; set; }
}

namespace FoundItBE_Users.Domain;

public interface IPostGresRepository
{
    Task GetUserFromDatabase(string username, string password);
}

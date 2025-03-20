namespace FoundItBE_Users.BusinessLayer;

public static class Consts
{
    public const string InsertUser = $"INSERT INTO users (username, password, email) VALUES (@username, @password, @email)";
}

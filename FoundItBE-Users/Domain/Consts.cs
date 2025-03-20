namespace FoundItBE_Users.Domain;

public static class Consts
{
    public const string InsertUser = $"INSERT INTO users (username, password, email) VALUES (@username, @password, @email)";

    public const string GetUserByUsername = @"SELECT * from users WHERE username=@username";
}

using System.ComponentModel.DataAnnotations;

namespace FoundItBE_Users.Models;

public class User
{
    public Guid Id { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }
}

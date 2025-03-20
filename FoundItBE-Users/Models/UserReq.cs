using System.ComponentModel.DataAnnotations;

namespace FoundItBE_Users.Models;

public class UserReq
{
    public Guid Id = Guid.NewGuid();

    [Required]
    public string UserName { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public string Email { get; set; }
}

using FluentValidation;
using FoundItBE_Users.Models;

namespace FoundItBE_Users.Validation;

public class UserCredentialsValidator : AbstractValidator<UserCredentials>
{
    public UserCredentialsValidator()
    {
        RuleFor(x => x.UserName).NotEmpty();
        RuleFor(x => x.Password).NotEmpty();
    }
}

using FluentValidation;
using FoundItBE_Users.Models;

namespace FoundItBE_Users.Validation;

public class UserReqValidator : AbstractValidator<UserReq>
{
    public UserReqValidator()
    {
        RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName must not be empty");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email must not be empty");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Password must not be empty");
    }
}

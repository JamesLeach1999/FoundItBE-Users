using FluentValidation;
using FoundItBE_Users.Models;
using FoundItBE_Users.Validation;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mime;

namespace FoundItBE_Users.Controllers;


[ApiController]
[Route("[controller]")]
public class GetUserController(AbstractValidator<UserCredentials> userCredentialsValidator) : Controller
{
    [HttpPost]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    public async Task<IActionResult> UserLogin([FromBody] UserCredentials userCredentials)
    {
        var validatedUser = userCredentialsValidator.Validate(userCredentials);

        if (!validatedUser.IsValid) {
            return BadRequest();
        }

        return Ok(userCredentials);
    }
}

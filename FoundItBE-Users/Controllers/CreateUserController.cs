using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Net;
using System.Net.Mime;
using FoundItBE_Users.Models;
using FluentValidation;
using Npgsql;
using FoundItBE_Users.Domain;


namespace FoundItBE_Users.Controllers;

[ApiController]
[Route("[controller]")]
public class CreateUserController(AbstractValidator<UserReq> userRequestValidator, IPostGresRepository createNewUserService) : Controller
{
    [HttpPost]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType((int)HttpStatusCode.Created)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    public async Task<IActionResult> Index([FromBody] UserReq userReq)
    {
        try
        {
            var validatedUser = userRequestValidator.Validate(userReq);

            if (!validatedUser.IsValid)
            {
                return BadRequest();
            }

            await createNewUserService.CreateUser(userReq);

            return Created();
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
}

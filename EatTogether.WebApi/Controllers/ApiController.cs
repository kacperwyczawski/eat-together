using ErrorOr;
using Microsoft.AspNetCore.Mvc;

namespace EatTogether.WebApi.Controllers;

[ApiController]
public class ApiController : ControllerBase
{
    protected IActionResult Problem(List<Error> errors)
    {
        return Problem(title: errors[0].Description); // temporary solution
    }
}
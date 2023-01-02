using EatTogether.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace EatTogether.WebApi.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        return Ok();
    }
    
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        return Ok();
    }
}
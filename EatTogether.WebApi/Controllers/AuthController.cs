using EatTogether.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace EatTogether.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost]
    public IActionResult Login(LoginRequest request)
    {
        return Ok();
    }
    
    [HttpPost]
    public IActionResult Register(RegisterRequest request)
    {
        return Ok();
    }
}
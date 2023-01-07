using EatTogether.Application.Services.Authentication;
using EatTogether.Application.Services.Authentication.Commands;
using EatTogether.Application.Services.Authentication.Common;
using EatTogether.Application.Services.Authentication.Queries;
using EatTogether.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace EatTogether.WebApi.Controllers;

[Route("auth")]
public class AuthenticationController : ApiController
{
    private readonly IAuthenticationCommandService _authenticationCommandService;
    private readonly IAuthenticationQueryService _authenticationQueryService;

    public AuthenticationController(
        IAuthenticationQueryService authenticationQueryService,
        IAuthenticationCommandService authenticationCommandService)
    {
        _authenticationQueryService = authenticationQueryService;
        _authenticationCommandService = authenticationCommandService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var maybeResult = _authenticationCommandService.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);

        return maybeResult.Match(
            onValue: result => Ok(MapToResponse(result)),
            onError: Problem);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var maybeResult = _authenticationQueryService.Login(
            request.Email,
            request.Password);

        return maybeResult.Match(
            onValue: result => Ok(MapToResponse(result)),
            onError: Problem);
    }

    private static AuthenticationResponse MapToResponse(AuthenticationResult result)
    {
        var response = new AuthenticationResponse(
            result.User.Id,
            result.User.FirstName,
            result.User.LastName,
            result.User.Email,
            result.Token);
        return response;
    }
}
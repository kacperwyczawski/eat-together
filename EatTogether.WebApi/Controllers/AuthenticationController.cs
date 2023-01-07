using EatTogether.Application.Authentication.Commands.Register;
using EatTogether.Application.Authentication.Common;
using EatTogether.Application.Authentication.Queries.Login;
using EatTogether.Contracts.Authentication;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EatTogether.WebApi.Controllers;

[Route("auth")]
public class AuthenticationController : ApiController
{
    private readonly ISender _mediator;

    public AuthenticationController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = new RegisterCommand(request.Email, request.Password, request.FirstName, request.LastName);
        var maybeResult = await _mediator.Send(command);

        return maybeResult.Match(
            onValue: result => Ok(MapToResponse(result)),
            onError: Problem);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var query = new LoginQuery(request.Email, request.Password);
        var maybeResult = await _mediator.Send(query);

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
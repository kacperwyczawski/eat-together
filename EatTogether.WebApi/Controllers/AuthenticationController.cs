using EatTogether.Application.Authentication.Commands.Register;
using EatTogether.Application.Authentication.Queries.Login;
using EatTogether.Contracts.Authentication;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EatTogether.WebApi.Controllers;

[Route("auth")]
public class AuthenticationController : ApiController
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public AuthenticationController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = _mapper.Map<RegisterCommand>(request);
        var maybeResult = await _mediator.Send(command);

        return maybeResult.Match(
            onValue: result => Ok(_mapper.Map<AuthenticationResponse>(result)),
            onError: Problem);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var query = _mapper.Map<LoginQuery>(request);
        var maybeResult = await _mediator.Send(query);

        return maybeResult.Match(
            onValue: result => Ok(_mapper.Map<AuthenticationResponse>(result)),
            onError: Problem);
    }
}
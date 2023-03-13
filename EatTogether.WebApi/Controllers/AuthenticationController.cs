using EatTogether.Application.AuthenticationFeature.Commands.Register;
using EatTogether.Application.AuthenticationFeature.Queries.Login;
using EatTogether.Contracts.AuthenticationContracts;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EatTogether.WebApi.Controllers;

[Route("auth")]
[AllowAnonymous]
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
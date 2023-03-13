using EatTogether.Application.MenuFeature.CreateMenu;
using EatTogether.Contracts.MenuContracts;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EatTogether.WebApi.Controllers;

[Route("hosts/{hostId}/menus")]
public class MenuController : ApiController
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public MenuController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateMenu(CreateMenuRequest request, string hostId)
    {
        var command = _mapper.Map<CreateMenuCommand>((request, hostId));
        var result = await _mediator.Send(command);
        return result.Match(
            menu => Ok(_mapper.Map<CreateMenuResponse>(menu)),
            errors => Problem(errors));
    }
}
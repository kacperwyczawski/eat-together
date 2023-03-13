using EatTogether.Domain.Features.MenuAggregate;
using ErrorOr;
using MediatR;

namespace EatTogether.Application.MenuFeature.CreateMenu;

public record CreateMenuCommand(string HostId, string Name, string Description, List<CreateMenuSectionCommand> Sections)
    : IRequest<ErrorOr<Menu>>;

public record CreateMenuSectionCommand(string Name, string Description, List<CreateMenuItemCommand> Items);

public record CreateMenuItemCommand(string Name, string Description);
using EatTogether.Application.Common.Interfaces.Persistence;
using EatTogether.Domain.Features.MenuAggregate;
using EatTogether.Domain.Features.MenuAggregate.Entities;
using ErrorOr;
using MediatR;

namespace EatTogether.Application.MenuFeature.CreateMenu;

public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
{
    private readonly IMenuRepository _menuRepository;

    public CreateMenuCommandHandler(IMenuRepository menuRepository)
    {
        _menuRepository = menuRepository;
    }

    public async Task<ErrorOr<Menu>> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
    {
        var menu = new Menu(
            request.Name, 
            request.Description, 
            new Guid(request.HostId),
            request.Sections.ConvertAll(section => new MenuSection(
                section.Name,
                section.Description,
                section.Items.ConvertAll(item => new MenuItem(
                    item.Name,
                    item.Description
                ))
            ))
        );
        
        await Task.CompletedTask; // temporary
        _menuRepository.Add(menu);

        return menu;
    }
}
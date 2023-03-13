using EatTogether.Application.Common.Interfaces.Persistence;
using EatTogether.Domain.Features.MenuAggregate;

namespace EatTogether.Infrastructure.Persistent;

public class MenuRepository : IMenuRepository
{
    private static readonly List<Menu> Menus = new();

    public void Add(Menu menu)
    {
        Menus.Add(menu);
    }
}
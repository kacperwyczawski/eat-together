using EatTogether.Domain.Features.MenuAggregate;

namespace EatTogether.Application.Common.Interfaces.Persistence;

public interface IMenuRepository
{
    public void Add(Menu menu);
}
using EatTogether.Domain.Features.MenuAggregate.Entities;
using EatTogether.Domain.Shared.ValueObjects;

namespace EatTogether.Domain.Features.MenuAggregate;

public sealed class Menu : AggregateRoot
{
    public Guid HostId { get; }
    private readonly List<Guid> _mealIds = new();
    public IReadOnlyList<Guid> MealIds => _mealIds.AsReadOnly();
    private readonly List<Guid> _menuReviewIds = new();
    public IReadOnlyList<Guid> MenuReviewIds => _menuReviewIds.AsReadOnly();

    public string Name { get; }

    public string Description { get; }

    public Rating? AverageRating { get; }

    private readonly List<MenuSection> _sections;

    public Menu(string name, string description, Guid hostId, List<MenuSection> sections, Rating? averageRating = null)
    {
        Name = name;
        Description = description;
        AverageRating = averageRating;
        HostId = hostId;
        _sections = sections;
    }

    public IReadOnlyList<MenuSection> Sections => _sections.AsReadOnly();
}
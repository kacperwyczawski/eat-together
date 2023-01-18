using EatTogether.Domain.Features.Menu.Entities;
using EatTogether.Domain.Shared.ValueObjects;

namespace EatTogether.Domain.Features.Menu;

public sealed class Menu : AggregateRoot
{
    public string Name { get; }
    
    public string Description { get; }
    
    public Rating AverageRating { get; }
    
    private readonly List<MenuSection> _sections = new();

    public Menu(Guid id, string name, string description, Rating averageRating) : base(id)
    {
        Name = name;
        Description = description;
        AverageRating = averageRating;
    }
    
    public IReadOnlyList<MenuSection> Sections => _sections.AsReadOnly();
}
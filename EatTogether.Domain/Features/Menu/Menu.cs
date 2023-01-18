using EatTogether.Domain.Features.Menu.Entities;

namespace EatTogether.Domain.Features.Menu;

public sealed class Menu : AggregateRoot<Guid>
{
    public string Name { get; }
    public string Description { get; }
    public float AverageRating { get; }
    private readonly List<MenuSection> _sections = new();

    public Menu(Guid id, string name, string description) : base(id)
    {
        Name = name;
        Description = description;
    }
    
    public IReadOnlyList<MenuSection> Sections => _sections.AsReadOnly();
}
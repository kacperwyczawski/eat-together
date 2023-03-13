namespace EatTogether.Domain.Features.MenuAggregate.Entities;

public sealed class MenuSection : Entity
{
    public string Name { get; }
    public string Description { get; }
    private readonly List<MenuItem> _items;

    public MenuSection(string name, string description, List<MenuItem> items)
    {
        Description = description;
        _items = items;
        Name = name;
    }
    
    public IReadOnlyCollection<MenuItem> Items => _items.AsReadOnly();
}
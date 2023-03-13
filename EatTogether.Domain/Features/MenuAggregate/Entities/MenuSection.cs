namespace EatTogether.Domain.Features.MenuAggregate.Entities;

public sealed class MenuSection : Entity
{
    public string Name { get; }
    public string Description { get; }
    private readonly List<MenuItem> _items = new ();

    public MenuSection(Guid id, string name, string description) : base(id)
    {
        Description = description;
        Name = name;
    }
    
    public IReadOnlyCollection<MenuItem> Items => _items.AsReadOnly();
}
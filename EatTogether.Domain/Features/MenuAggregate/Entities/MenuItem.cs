namespace EatTogether.Domain.Features.MenuAggregate.Entities;

public sealed class MenuItem : Entity
{
    public string Name { get; }
    public string Description { get; }
    
    public MenuItem(Guid id, string name, string description) : base(id)
    {
        Name = name;
        Description = description;
    }
}
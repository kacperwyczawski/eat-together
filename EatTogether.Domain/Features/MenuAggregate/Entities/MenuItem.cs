namespace EatTogether.Domain.Features.MenuAggregate.Entities;

public sealed class MenuItem : Entity
{
    public string Name { get; }
    public string Description { get; }
    
    public MenuItem(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
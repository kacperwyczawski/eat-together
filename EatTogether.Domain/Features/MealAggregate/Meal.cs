using EatTogether.Domain.Shared.ValueObjects;

namespace EatTogether.Domain.Features.MealAggregate;

public class Meal : AggregateRoot
{
    public readonly Guid HostId;
    public readonly Guid MenuId;

    public string Name { get; }
    public string Description { get; }
    public DateTime Start { get; }
    public DateTime End { get; }
    public int MaxGuests { get; }
    public Price Price { get; }
    public string ImageUrl { get; }

    public Meal(Guid id, string name, string description, DateTime start, DateTime end, int maxGuests,
        Price price, string imageUrl, DateTime createdAt, DateTime updatedAt, Guid hostId, Guid menuId) : base(id,
        createdAt, updatedAt)
    {
        Name = name;
        Description = description;
        Start = start;
        End = end;
        MaxGuests = maxGuests;
        Price = price;
        ImageUrl = imageUrl;
        HostId = hostId;
        MenuId = menuId;
    }
}
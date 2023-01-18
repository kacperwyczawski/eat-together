using EatTogether.Domain.Shared.ValueObjects;

namespace EatTogether.Domain.Features.Meal;

public class Meal : AggregateRoot
{
    public string Name { get; }
    public string Description { get; }
    public DateTime Start { get; }
    public DateTime End { get; }
    public int MaxGuests { get; }
    public Price Price { get; }
    public string ImageUrl { get; }

    protected Meal(Guid id, string name, string description, DateTime start, DateTime end, int maxGuests,
        Price price, string imageUrl) : base(id)
    {
        Name = name;
        Description = description;
        Start = start;
        End = end;
        MaxGuests = maxGuests;
        Price = price;
        ImageUrl = imageUrl;
    }
}
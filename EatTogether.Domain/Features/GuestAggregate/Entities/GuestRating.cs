using EatTogether.Domain.Shared.ValueObjects;

namespace EatTogether.Domain.Features.GuestAggregate.Entities;

public class GuestRating : Entity
{
    public Rating Rating { get; }
    
    public GuestRating(Rating rating)
    {
        Rating = rating;
    }
}
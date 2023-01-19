using EatTogether.Domain.Shared.ValueObjects;

namespace EatTogether.Domain.Features.MenuReview;

public sealed class MenuReview : AggregateRoot
{
    public Rating Rating { get; }
    public string Comment { get; }

    public MenuReview(Guid id, Rating rating, string comment) : base(id)
    {
        Rating = rating;
        Comment = comment;
    }
}
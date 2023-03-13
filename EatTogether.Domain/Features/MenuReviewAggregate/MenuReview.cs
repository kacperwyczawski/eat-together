using EatTogether.Domain.Shared.ValueObjects;

namespace EatTogether.Domain.Features.MenuReviewAggregate;

public sealed class MenuReview : AggregateRoot
{
    public Guid HostId { get; }
    public Guid MenuId { get; }
    public Guid GuestId { get; }
    public Guid MealId { get; }

    public Rating Rating { get; }
    public string Comment { get; }

    public MenuReview(Rating rating, string comment, Guid hostId,
        Guid menuId, Guid guestId, Guid mealId)
    {
        Rating = rating;
        Comment = comment;
        HostId = hostId;
        MenuId = menuId;
        GuestId = guestId;
        MealId = mealId;
    }
}
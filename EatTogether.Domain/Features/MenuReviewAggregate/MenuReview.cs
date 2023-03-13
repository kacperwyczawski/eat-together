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

    public MenuReview(Guid id, Rating rating, string comment, DateTime createdAt, DateTime updatedAt, Guid hostId,
        Guid menuId, Guid guestId, Guid mealId) : base(id, createdAt, updatedAt)
    {
        Rating = rating;
        Comment = comment;
        HostId = hostId;
        MenuId = menuId;
        GuestId = guestId;
        MealId = mealId;
    }
}
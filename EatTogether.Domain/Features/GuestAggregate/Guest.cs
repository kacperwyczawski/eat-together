using EatTogether.Domain.Features.GuestAggregate.Entities;

namespace EatTogether.Domain.Features.GuestAggregate;

public sealed class Guest : AggregateRoot
{
    private readonly List<Guid> _upcomingMealIds = new();
    public IReadOnlyList<Guid> UpcomingMealIds => _upcomingMealIds.AsReadOnly();
    private readonly List<Guid> _pastMealIds = new();
    public IReadOnlyList<Guid> PastMealIds => _pastMealIds.AsReadOnly();
    private readonly List<Guid> _pendingMealIds = new();
    public IReadOnlyList<Guid> PendingMealIds => _pendingMealIds.AsReadOnly();
    private readonly List<Guid> _billIds = new();
    public IReadOnlyList<Guid> BillIds => _billIds.AsReadOnly();
    private readonly List<Guid> _menuReviewsIds = new();
    public IReadOnlyList<Guid> MenuReviewIds => _menuReviewsIds.AsReadOnly();


    public string Name { get; }
    public string LastName { get; }
    public string ProfilePictureUrl { get; }
    private readonly List<GuestRating> _ratings = new();

    public Guest(Guid id, string name, string lastName, string profilePictureUrl, DateTime createdAt,
        DateTime updatedAt) : base(id, createdAt, updatedAt)
    {
        Name = name;
        LastName = lastName;
        ProfilePictureUrl = profilePictureUrl;
    }
}
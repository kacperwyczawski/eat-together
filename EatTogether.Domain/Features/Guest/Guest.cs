using EatTogether.Domain.Features.Guest.Entities;

namespace EatTogether.Domain.Features.Guest;

public sealed class Guest : AggregateRoot
{
    public string Name { get; }
    public string LastName { get; }
    public string ProfilePictureUrl { get; }
    private readonly List<GuestRating> _ratings = new();

    protected Guest(Guid id, string name, string lastName, string profilePictureUrl) : base(id)
    {
        Name = name;
        LastName = lastName;
        ProfilePictureUrl = profilePictureUrl;
    }
}
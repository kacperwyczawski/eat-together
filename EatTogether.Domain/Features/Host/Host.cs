namespace EatTogether.Domain.Features.Host;

public sealed class Host : AggregateRoot
{
    public string FirstName { get; }
    public string LastName { get; }
    public string ProfilePictureUrl { get; }

    public Host(Guid id, string firstName, string lastName, string profilePictureUrl) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        ProfilePictureUrl = profilePictureUrl;
    }
}
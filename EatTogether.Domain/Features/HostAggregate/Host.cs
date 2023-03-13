namespace EatTogether.Domain.Features.HostAggregate;

public sealed class Host : AggregateRoot
{
    private readonly Guid _userId;
    private readonly List<Guid> _menuIds = new();
    public IReadOnlyList<Guid> MenuIds => _menuIds.AsReadOnly();
    private readonly List<Guid> _mealIds = new();
    public IReadOnlyList<Guid> MealIds => _mealIds.AsReadOnly();

    public string FirstName { get; }
    public string LastName { get; }
    public string ProfilePictureUrl { get; }

    public Host(string firstName, string lastName, string profilePictureUrl, Guid userId)
    {
        FirstName = firstName;
        LastName = lastName;
        ProfilePictureUrl = profilePictureUrl;
        _userId = userId;
    }
}
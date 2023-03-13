namespace EatTogether.Domain.Features.UserAggregate;

public sealed class User : AggregateRoot
{
    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public string Password { get; } // TODO: Hash password

    public User(Guid id, string firstName, string lastName, string email, string password, DateTime createdAt,
        DateTime updatedAt) : base(id, createdAt, updatedAt)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }
}
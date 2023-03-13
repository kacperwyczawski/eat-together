namespace EatTogether.Contracts.AuthenticationContracts;

public record AuthenticationResponse(Guid Id, string FirstName, string LastName, string Email, string Token);
namespace EatTogether.Contracts.AuthenticationContracts;

public record RegisterRequest(string FirstName, string LastName, string Email, string Password);
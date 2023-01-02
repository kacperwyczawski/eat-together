namespace EatTogether.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string email, string password)
    {
        // temporary data
        return new AuthenticationResult(
            Guid.Empty,
            "Elvis",
            "Presley",
            email,
            "token");
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        // temporary data
        return new AuthenticationResult(
            Guid.Empty,
            firstName,
            lastName,
            email,
            "token");
    }
}
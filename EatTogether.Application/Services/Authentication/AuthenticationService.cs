using EatTogether.Application.Common.Interfaces;

namespace EatTogether.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _tokenGenerator;

    public AuthenticationService(IJwtTokenGenerator tokenGenerator)
    {
        _tokenGenerator = tokenGenerator;
    }

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
        var userId = Guid.NewGuid();
        
        return new AuthenticationResult(
            userId,
            firstName,
            lastName,
            email,
            _tokenGenerator.GenerateToken(userId, firstName, lastName));
    }
}
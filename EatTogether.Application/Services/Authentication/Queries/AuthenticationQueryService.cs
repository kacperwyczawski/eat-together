using EatTogether.Application.Common.Interfaces.Authentication;
using EatTogether.Application.Common.Interfaces.Persistence;
using EatTogether.Application.Services.Authentication.Common;
using EatTogether.Domain.Errors;
using ErrorOr;

namespace EatTogether.Application.Services.Authentication.Queries;

public class AuthenticationQueryService : IAuthenticationQueryService
{
    private readonly IJwtTokenGenerator _tokenGenerator;

    private readonly IUserRepository _userRepository;

    public AuthenticationQueryService(IJwtTokenGenerator tokenGenerator, IUserRepository userRepository)
    {
        _tokenGenerator = tokenGenerator;
        _userRepository = userRepository;
    }

    public ErrorOr<AuthenticationResult> Login(string email, string password)
    {
        var user = _userRepository.GetByEmail(email);

        if (user is null
            || user.Password != password)
            return Errors.Authentication.InvalidCredentials;

        var token = _tokenGenerator.GenerateToken(user);

        return new AuthenticationResult(user, token);
    }
}
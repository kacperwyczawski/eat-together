using EatTogether.Application.Common.Interfaces.Authentication;
using EatTogether.Application.Common.Interfaces.Persistence;
using EatTogether.Application.Services.Authentication.Common;
using EatTogether.Domain.Entities;
using EatTogether.Domain.Errors;
using ErrorOr;

namespace EatTogether.Application.Services.Authentication.Commands;

public class AuthenticationCommandService : IAuthenticationCommandService
{
    private readonly IJwtTokenGenerator _tokenGenerator;

    private readonly IUserRepository _userRepository;

    public AuthenticationCommandService(IJwtTokenGenerator tokenGenerator, IUserRepository userRepository)
    {
        _tokenGenerator = tokenGenerator;
        _userRepository = userRepository;
    }

    public ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password)
    {
        if (_userRepository.GetByEmail(email) is not null)
            return Errors.User.DuplicateEmail;

        var user = new User(firstName, lastName, email, password);

        _userRepository.Add(user);

        var token = _tokenGenerator.GenerateToken(user);

        return new AuthenticationResult(user, token);
    }
}
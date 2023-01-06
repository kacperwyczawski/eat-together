using EatTogether.Application.Common.Interfaces.Authentication;
using EatTogether.Application.Common.Interfaces.Persistence;
using EatTogether.Domain.Entities;

namespace EatTogether.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _tokenGenerator;

    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator tokenGenerator, IUserRepository userRepository)
    {
        _tokenGenerator = tokenGenerator;
        _userRepository = userRepository;
    }

    public AuthenticationResult Login(string email, string password)
    {
        var user = _userRepository.GetByEmail(email);

        if (user is null)
            throw new Exception("User with given email not found");

        if (user.Password != password)
            throw new Exception("Invalid password");

        var token = _tokenGenerator.GenerateToken(user);

        return new AuthenticationResult(user, token);
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        if (_userRepository.GetByEmail(email) is not null)
            throw new Exception("User with given email already exists");

        var user = new User(firstName, lastName, email, password);

        _userRepository.Add(user);

        var token = _tokenGenerator.GenerateToken(user);

        return new AuthenticationResult(user, token);
    }
}
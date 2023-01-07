using EatTogether.Application.Authentication.Common;
using EatTogether.Application.Common.Interfaces.Authentication;
using EatTogether.Application.Common.Interfaces.Persistence;
using ErrorOr;
using EatTogether.Domain.Errors;
using MediatR;

namespace EatTogether.Application.Authentication.Queries.Login;

public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    private readonly IUserRepository _userRepository;

    public LoginQueryHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery query, CancellationToken cancellationToken)
    {
        var user = _userRepository.GetByEmail(query.Email);
        
        if (user is null
            || user.Password != query.Password)
            return Task.FromResult<ErrorOr<AuthenticationResult>>(Errors.Authentication.InvalidCredentials);
        
        var token = _jwtTokenGenerator.GenerateToken(user);
        
        return Task.FromResult<ErrorOr<AuthenticationResult>>(new AuthenticationResult(user, token));
    }
}
using EatTogether.Application.Services.Authentication.Common;
using ErrorOr;

namespace EatTogether.Application.Services.Authentication.Commands;

public interface IAuthenticationCommandService
{
    public ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password);
}
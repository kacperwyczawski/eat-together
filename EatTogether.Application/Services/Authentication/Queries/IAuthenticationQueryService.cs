using EatTogether.Application.Services.Authentication.Common;
using ErrorOr;

namespace EatTogether.Application.Services.Authentication.Queries;

public interface IAuthenticationQueryService
{
    public ErrorOr<AuthenticationResult> Login(string email, string password);
}
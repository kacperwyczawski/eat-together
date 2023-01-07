using EatTogether.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace EatTogether.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;
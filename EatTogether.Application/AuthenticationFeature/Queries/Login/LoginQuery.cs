using EatTogether.Application.AuthenticationFeature.Common;
using ErrorOr;
using MediatR;

namespace EatTogether.Application.AuthenticationFeature.Queries.Login;

public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;
using EatTogether.Domain.Features.UserAggregate;

namespace EatTogether.Application.Authentication.Common;

public record AuthenticationResult(User User, string Token);
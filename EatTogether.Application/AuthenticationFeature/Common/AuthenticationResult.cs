using EatTogether.Domain.Features.UserAggregate;

namespace EatTogether.Application.AuthenticationFeature.Common;

public record AuthenticationResult(User User, string Token);
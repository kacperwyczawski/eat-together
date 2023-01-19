using EatTogether.Domain.Features.User;

namespace EatTogether.Application.Authentication.Common;

public record AuthenticationResult(User User, string Token);
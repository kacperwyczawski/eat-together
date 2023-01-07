using EatTogether.Domain.Entities;

namespace EatTogether.Application.Services.Authentication.Common;

public record AuthenticationResult(User User, string Token);
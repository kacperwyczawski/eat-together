using EatTogether.Domain.Entities;

namespace EatTogether.Application.Services.Authentication;

public record AuthenticationResult(User User, string Token);
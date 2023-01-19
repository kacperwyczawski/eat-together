using EatTogether.Domain.Features.User;

namespace EatTogether.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
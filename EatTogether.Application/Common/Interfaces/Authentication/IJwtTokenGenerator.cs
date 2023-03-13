using EatTogether.Domain.Features.UserAggregate;

namespace EatTogether.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
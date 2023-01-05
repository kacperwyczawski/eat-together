using EatTogether.Domain.Entities;

namespace EatTogether.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
using EatTogether.Domain.Features.UserAggregate;

namespace EatTogether.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetByEmail(string email);
    
    void Add(User user);
}
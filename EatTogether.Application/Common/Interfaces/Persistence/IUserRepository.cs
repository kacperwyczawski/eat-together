using EatTogether.Domain.Features.User;

namespace EatTogether.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetByEmail(string email);
    
    void Add(User user);
}
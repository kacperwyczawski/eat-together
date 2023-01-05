using EatTogether.Application.Common.Interfaces.Persistence;
using EatTogether.Domain.Entities;

namespace EatTogether.Infrastructure.Persistent;

public class UserRepository : IUserRepository
{
    private static readonly List<User> Users = new(); // temporary solution

    public User? GetByEmail(string email) => Users.FirstOrDefault(x => x.Email == email);

    public void Add(User user) => Users.Add(user);
}
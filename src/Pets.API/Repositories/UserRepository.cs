using Pets.API.Entities;
using Pets.API.Interfaces.Repositories;

namespace Pets.API.Repositories;

public class UserRepository : IUserRepository
{
    private readonly EntityContext _context;
    
    public UserRepository(
        EntityContext context
    )
    {
        _context = context;
    }
    
    public User Create(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return user;
    }
}
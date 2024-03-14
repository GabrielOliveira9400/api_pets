using Pets.API.Entities;
using Pets.API.Interfaces.Repositories;
using Pets.API.Interfaces.Services;

namespace Users.API.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    
    public UserService(
        IUserRepository userRepository
    )
    {
        _userRepository = userRepository;
    }
    
    public User CreateUser(User user)
    {
        try
        {
            var result = _userRepository.Create(user);
            return result;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
using Pets.API.Entities;

namespace Pets.API.Interfaces.Services;

public interface IUserService
{
    public User CreateUser(User user);
}
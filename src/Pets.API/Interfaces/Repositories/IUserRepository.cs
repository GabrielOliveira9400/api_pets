using Pets.API.Entities;

namespace Pets.API.Interfaces.Repositories;

public interface IUserRepository
{
    public User Create(User user);
}
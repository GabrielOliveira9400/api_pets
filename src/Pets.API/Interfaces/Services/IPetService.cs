using Pets.API.Entities;

namespace Pets.API.Interfaces.Services;

public interface IPetService
{
    public Pet GetPet(int id);
}
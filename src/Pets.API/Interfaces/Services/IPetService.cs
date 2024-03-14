using Pets.API.DTOs;
using Pets.API.Entities;

namespace Pets.API.Interfaces.Services;

public interface IPetService
{
    public Pet GetPet(int id);
    public Task<DTOdePetDetails> GetPetDetails(int id);
    public string removePet(int id);
}
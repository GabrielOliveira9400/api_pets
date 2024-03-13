using Pets.API.DTOs;
using Pets.API.Entities;
using Pets.API.Interfaces.Repositories;
using Pets.API.Interfaces.Services;

namespace Pets.API.Services;

public class PetService : IPetService
{
    private readonly IPetRepository _petRepository;
    
    public PetService(
        IPetRepository petRepository
        )
    {
        _petRepository = petRepository;
    }

    public Pet GetPet(int id)
    {
        var pet = _petRepository.GetById(id);
        return pet;
    }
    
}
using Microsoft.EntityFrameworkCore;
using Pets.API.DTOs;
using Pets.API.Entities;
using Pets.API.Interfaces.Repositories;

namespace Pets.API.Repositories;

public class PetRepository : IPetRepository
{
    private readonly EntityContext _context;
    
    public PetRepository(
        EntityContext context
        )
    {
        _context = context;
    }
    
    public void Add(Pet pet)
    {
        _context.Pets.Add(pet);
        _context.SaveChanges();
    }
    
    public void Update(Pet pet)
    {
        _context.Pets.Update(pet);
        _context.SaveChanges();
    }
    
    public bool Remove(Pet pet)
    {
        try
        {
            _context.Pets.Remove(pet);
            _context.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
    
    public Pet GetById(int id)
    {
        return _context.Pets.Find(id);
    }

    public Task<DTOdePetDetails> GetPetDetails(int id)
    {
        var pet = _context.Pets.Include(p => p.Vaccines).FirstOrDefault(p => p.Id == id);
        var dono = _context.Users.FirstOrDefault(u => u.Id == pet.UserId);
        var dto = new DTOdePetDetails
        {
            Id = pet.Id,
            OwnerId = pet.UserId,
            Name = pet.Name,
            Type = pet.Type,
            BirthDate = pet.BirthDate,
            age = (DateTime.Now.Year - pet.BirthDate.Year).ToString(),
            OwnerName = dono.Name,
            gender = pet.gender,
            Weight = pet.Weight,
            Description = pet.Description,
            Picture = pet.Picture,
            Vaccines = pet.Vaccines,
            breed = pet.breed
        };
        
        return Task.FromResult(dto);
    }
}
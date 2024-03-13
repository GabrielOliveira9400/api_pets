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
    
    public void Remove(Pet pet)
    {
        _context.Pets.Remove(pet);
        _context.SaveChanges();
    }
    
    public Pet GetById(int id)
    {
        return _context.Pets.Find(id);
    }
}
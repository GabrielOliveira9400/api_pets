using Pets.API.Entities;

namespace Pets.API.Interfaces.Repositories;

public interface IPetRepository
{
    public void Add(Pet pet);
    public void Update(Pet pet);
    public void Remove(Pet pet);
    public Pet GetById(int id);
    
}
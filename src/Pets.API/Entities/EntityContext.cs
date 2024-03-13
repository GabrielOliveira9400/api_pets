using Microsoft.EntityFrameworkCore;
namespace Pets.API.Entities;

public class EntityContext : DbContext
{

    public EntityContext(DbContextOptions<EntityContext> options) : base(options)
    {
        
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Vaccine> Vaccines { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
}
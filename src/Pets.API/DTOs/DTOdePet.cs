using Pets.API.Entities;

namespace Pets.API.DTOs;

public class DTOdePetDetails
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public DateTime BirthDate { get; set; }
    public string gender { get; set; }
    public double Weight { get; set; }
    public string Description { get; set; }
    public string Picture { get; set; }
    public List<Vaccine> Vaccines { get; set; }
    public string breed { get; set; }
    public string OwnerName { get; set; }
    public string age { get; set; }
    
}
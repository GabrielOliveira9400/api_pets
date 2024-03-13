namespace Pets.API.Entities;

public class Vaccine
{
    public int id { get; set; }
    public int petId { get; set; }
    public string name { get; set; }
    public DateTime applicationDate { get; set; }
    public string applicationLocation { get; set; }
    public string veterinarian { get; set; }
    public string efficiency { get; set; }
    public int ageAtApplication { get; set; }
    public DateTime expirationDate { get; set; }
}
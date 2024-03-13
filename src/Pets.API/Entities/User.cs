﻿namespace Pets.API.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<Pet> Pets { get; set; } = new List<Pet>();
}
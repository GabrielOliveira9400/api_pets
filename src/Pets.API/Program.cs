using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Pets.API.Entities;
using Pets.API.Interfaces.Repositories;
using Pets.API.Interfaces.Services;
using Pets.API.Repositories;
using Pets.API.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme.
                        Enter 'Bearer' [space] and then your token in the text input below.
                        Example: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header
            },
            new List<string>()
        }
    });
});

/*builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IVaccineRepository, VaccineRepository>();*/
builder.Services.AddScoped<IPetRepository, PetRepository>();
builder.Services.AddScoped<IPetService, PetService>();
builder.Services.AddDbContext<EntityContext>(options => 
    options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=vacina_pets;Trusted_Connection=True;TrustServerCertificate=True;"));

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;
using System.Xml;

namespace personapi_dotnet.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Profesion> Profesiones { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<Estudio> Estudios { get; set; }
        }
}

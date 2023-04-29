using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Context;
using personapi_dotnet.Interfaces;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Repository
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PersonaRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       
        async Task IPersonaRepository.AddPersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        async Task IPersonaRepository.DeletePersona(int personaId)
        {
            throw new NotImplementedException();
        }
    
        async Task<IEnumerable<Persona>> IPersonaRepository.GetAllPersonas()
        {
            return await _dbContext.Personas.ToListAsync();
        }

        async Task<Persona> IPersonaRepository.GetPersonaById(int personaId)
        {
            throw new NotImplementedException();
        }

        async Task IPersonaRepository.UpdatePersona(Persona persona)
        {
            throw new NotImplementedException();
        }
    }
}

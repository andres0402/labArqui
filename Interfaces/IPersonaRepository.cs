using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Interfaces
{
    public interface IPersonaRepository
    {
        Task<IEnumerable<Persona>> GetAllPersonas();
        Task<Persona> GetPersonaById(int personaId);
        Task AddPersona(Persona persona);
        Task UpdatePersona(Persona persona);
        Task DeletePersona(int personaId);
    }
}

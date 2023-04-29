using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Interfaces
{
    public interface IEstudiosRepository
    {
        Task<IEnumerable<Estudio>> GetAllEstudios();
        Task<Estudio> GetEstudioById(int profesionId, int personaId);
        Task AddEstudio(Estudio estudio);
        Task UpdateEstudio(Estudio estudio);
        Task DeleteEstudio(int profesionId, int personaId);
    }
}

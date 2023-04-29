using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Interfaces
{
    public interface IProfesionRepository
    {
        Task<IEnumerable<Profesion>> GetAllProfesiones();
        Task<Profesion> GetProfesionById(int profesionId);
        Task AddProfesion(Profesion profesion);
        Task UpdateProfesion(Profesion profesion);
        Task DeleteProfesion(int profesionId);
    }
}

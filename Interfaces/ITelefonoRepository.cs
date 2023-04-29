using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Interfaces
{
    public interface ITelefonoRepository
    {
        Task<IEnumerable<Telefono>> GetAllTelefonos();
        Task<Telefono> GetTelefonoById(string telefonoId);
        Task AddTelefono(Telefono telefono);
        Task UpdateTelefono(Telefono telefono);
        Task DeleteTelefono(string telefonoId);
    }
}

using personapi_dotnet.Context;
using personapi_dotnet.Interfaces;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Repository
{
    public class TelefonoRepository : ITelefonoRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TelefonoRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        async Task ITelefonoRepository.AddTelefono(Telefono telefono)
        {
            throw new NotImplementedException();
        }

        async Task ITelefonoRepository.DeleteTelefono(string telefonoId)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Telefono>> ITelefonoRepository.GetAllTelefonos()
        {
            throw new NotImplementedException();
        }

        async Task<Telefono> ITelefonoRepository.GetTelefonoById(string telefonoId)
        {
            throw new NotImplementedException();
        }

        async Task ITelefonoRepository.UpdateTelefono(Telefono telefono)
        {
            throw new NotImplementedException();
        }
    }
}

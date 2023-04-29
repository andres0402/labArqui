using personapi_dotnet.Context;
using personapi_dotnet.Interfaces;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Repository
{
    public class ProfesionRepository : IProfesionRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProfesionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        async Task IProfesionRepository.AddProfesion(Profesion profesion)
        {
            throw new NotImplementedException();
        }

        async Task IProfesionRepository.DeleteProfesion(int profesionId)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Profesion>> IProfesionRepository.GetAllProfesiones()
        {
            throw new NotImplementedException();
        }

        async Task<Profesion> IProfesionRepository.GetProfesionById(int profesionId)
        {
            throw new NotImplementedException();
        }

        async Task IProfesionRepository.UpdateProfesion(Profesion profesion)
        {
            throw new NotImplementedException();
        }
    }
}

using personapi_dotnet.Context;
using personapi_dotnet.Interfaces;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Repository
{
    public class EstudiosRepository : IEstudiosRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EstudiosRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        async Task IEstudiosRepository.AddEstudio(Estudio estudio)
        {
            throw new NotImplementedException();
        }

        async Task IEstudiosRepository.DeleteEstudio(int profesionId, int personaId)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Estudio>> IEstudiosRepository.GetAllEstudios()
        {
            throw new NotImplementedException();
        }

        async Task<Estudio> IEstudiosRepository.GetEstudioById(int profesionId, int personaId)
        {
            throw new NotImplementedException();
        }

        async Task IEstudiosRepository.UpdateEstudio(Estudio estudio)
        {
            throw new NotImplementedException();
        }
    }
}

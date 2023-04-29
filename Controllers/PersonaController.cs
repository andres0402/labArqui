using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Interfaces;
using personapi_dotnet.Repository;

namespace personapi_dotnet.Controllers
{
    public class PersonaController : Controller
    {
        private readonly IPersonaRepository _repository;

        public PersonaController(IPersonaRepository repository)
        {
            _repository = repository;
        }
        [Route("personas")]
        public async Task<IActionResult> Index()
        {
            var personas = await _repository.GetAllPersonas();
            return View(personas);
        }

        [Route("personas/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            return View();
        }

        [Route("personas/crear")]
        public async Task<IActionResult> Create()
        {
            return View();
        }


        [Route("personas/{id}/editar")]
        public async Task<IActionResult> Edit(int id)
        {
            return View();
        }



        [Route("personas/{id}/eliminar")]
        public async Task<IActionResult> Delete(int id)
        {
            return View();
        }

        
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Interfaces;

namespace personapi_dotnet.Controllers
{
    public class ProfesionController : Controller
    {
        private readonly IProfesionRepository _repository;

        public ProfesionController(IProfesionRepository repository)
        {
            _repository = repository;
        }
        [Route("profesiones")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [Route("profesiones/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            return View();
        }

        [Route("profesiones/crear")]
        public async Task<IActionResult> Create()
        {
            return View();
        }



        [Route("profesiones/{id}/editar")]
        public async Task<IActionResult> Edit(int id)
        {
            return View();
        }


        [Route("profesiones/{id}/eliminar")]
        public async Task<IActionResult> Delete(int id)
        {
            return View();
        }

      
    }
}

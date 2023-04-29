using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Interfaces;

namespace personapi_dotnet.Controllers
{
    public class EstudiosController : Controller
    {
        private readonly IEstudiosRepository _repository;

        public EstudiosController(IEstudiosRepository repository)
        {
            _repository = repository;
        }
        [Route("estudios")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [Route("estudios/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            return View();
        }

        [Route("estudios/crear")]
        public async Task<IActionResult> Create()
        {
            return View();
        }



        [Route("estudios/{id}/editar")]
        public async Task<IActionResult> Edit(int id)
        {
            return View();
        }


        [Route("estudios/{id}/eliminar")]
        public async Task<IActionResult> Delete(int id)
        {
            return View();
        }

        
    }
}

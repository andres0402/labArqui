using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Interfaces;

namespace personapi_dotnet.Controllers
{
    public class TelefonoController : Controller
    {
        private readonly ITelefonoRepository _repository;

        public TelefonoController(ITelefonoRepository repository)
        {
            _repository = repository;
        }
        [Route("telefonos")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [Route("telefonos/{id}")]
        public async Task<IActionResult> Details(string id)
        {
            return View();
        }

        [Route("telefonos/crear")]
        public async Task<IActionResult> Create()
        {
            return View();
        }



        [Route("telefonos/{id}/editar")]
        public async Task<IActionResult> Edit(int id)
        {
            return View();
        }



        [Route("telefonos/{id}/eliminar")]
        public async Task<IActionResult> Delete(int id)
        {
            return View();
        }

        
    }
}

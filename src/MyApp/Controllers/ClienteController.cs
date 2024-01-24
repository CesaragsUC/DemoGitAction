using Microsoft.AspNetCore.Mvc;
using MyApp.Model;

namespace MyApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {

        [HttpGet(Name = "Clientes")]
        public async Task<IActionResult> Index()
        {
            var clientes = Cliente.ListaClientesFake();
            return Ok(clientes);
        }
    }
}

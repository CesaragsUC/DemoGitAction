using Microsoft.AspNetCore.Mvc;
using MyApp.Model;

namespace MyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {

        [HttpGet]
        [Route("todos")]
        public async Task<IActionResult> Index()
        {
            var clientes = Cliente.ListaClientesFake();
            return Ok(clientes);
        }

        [HttpGet]
        [Route("user")]
        public async Task<IActionResult> User()
        {
            var cliente = Cliente.ClientesFake();
            return Ok(cliente);
        }
    }
}

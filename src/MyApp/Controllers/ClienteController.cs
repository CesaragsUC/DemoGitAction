using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {

        [HttpGet(Name = "Clientes")]
        public async Task<IActionResult> Index()
        {
            return Ok("Bem vindo");
        }
    }
}

using FarmaMed.DomainModel.Interfaces.Services;
using FarmaMed.DomainModel.MedicamentoAggregate;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FarmaMed.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SintomasController : ControllerBase
    {
        private readonly ISintomaService _service;

        public SintomasController(ISintomaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var sintomas = await _service.BuscarTodosSintomas();
            return Ok(sintomas);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Sintoma sintoma)
        {
            await _service.AdicionarSintoma(sintoma);
            return Ok();
        }

    }
}
using AutoMapper;
using FarmaMed.API.ViewModels;
using FarmaMed.DomainModel.Interfaces.Services;
using FarmaMed.DomainModel.MedicamentoAggregate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaMed.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SintomasController : ControllerBase
    {
        private readonly ISintomaService _service;
        private readonly IMapper _mapper;

        public SintomasController(ISintomaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var sintomas = _mapper.Map<IEnumerable<SintomaViewModel>>(await _service.BuscarTodosSintomas());
            return Ok(sintomas);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SintomaViewModel viewModel)
        {
            var sintoma = new Sintoma
            {
                Descricao = viewModel.Descricao
            };

            await _service.AdicionarSintoma(sintoma);
            return Ok();
        }

    }
}
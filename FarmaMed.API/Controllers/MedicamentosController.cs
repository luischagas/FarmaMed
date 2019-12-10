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
    public class MedicamentosController : ControllerBase
    {
        private readonly IMedicamentoService _service;
        private readonly IMapper _mapper;

        public MedicamentosController(IMedicamentoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IActionResult> Get()
        {
            var medicamentos = _mapper.Map<IEnumerable<MedicamentoViewModel>> (await _service.BuscarTodosMedicamentos()); 

            return Ok(medicamentos);
        }

        [HttpPost]
        public async Task<IActionResult> Post(MedicamentoViewModel viewModel)
        {

            var medicamento = new Medicamento
            {
                Nome = viewModel.Nome,
                Preco = viewModel.Preco,
                MedicamentoSintomas = viewModel.Sintomas.Select(sintoma => new MedicamentoSintoma { SintomaId = sintoma.Id }).ToList()
            };

            await _service.AdicionarMedicamento(medicamento);
            return Ok();
        }
    }
}
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

        public MedicamentosController(IMedicamentoService service)
        {
            this._service = service;
        }

        public async Task<IActionResult> Get()
        {
            var medicamentos = await _service.BuscarTodosMedicamentos();

            var result = medicamentos
                        .Select(medicamento => new ListMedicamentoViewModel
                        {
                            Id = medicamento.Id,
                            Nome = medicamento.Nome,
                            Preco = medicamento.Preco,
                            Sintomas = medicamento.MedicamentoSintomas.Select(sintoma => sintoma.Sintoma.Descricao)
                        });

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(NewMedicamentoViewModel viewModel)
        {
            var medicamento = new Medicamento
            {
                Nome = viewModel.Nome,
                Preco = viewModel.Preco,
                MedicamentoSintomas = viewModel.Sintomas.Select(id => new MedicamentoSintoma { SintomaId = id }).ToList()
            };

            await _service.AdicionarMedicamento(medicamento);
            return Ok();
        }
    }
}
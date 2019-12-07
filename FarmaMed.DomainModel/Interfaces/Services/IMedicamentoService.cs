using FarmaMed.DomainModel.MedicamentoAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarmaMed.DomainModel.Interfaces.Services
{
    public interface IMedicamentoService
    {
        Task<Medicamento> BuscarMedicamento(Guid id);
        Task<IEnumerable<Medicamento>> BuscarTodosMedicamentos();
        Task AdicionarMedicamento(Medicamento medicamento);
        Task AtualizarMedicamento(Medicamento medicamento);
        Task RemoverMedicamento(Guid id);
    }
}

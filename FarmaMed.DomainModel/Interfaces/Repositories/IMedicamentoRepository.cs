using FarmaMed.DomainModel.MedicamentoAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarmaMed.DomainModel.Interfaces.Repositories
{
    public interface IMedicamentoRepository : IRepository<Medicamento>
    {
        Task<IEnumerable<Medicamento>> BuscarTodosMedicamentos();
    }
}

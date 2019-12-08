using FarmaMed.DomainModel.Interfaces.Repositories;
using FarmaMed.DomainModel.MedicamentoAggregate;
using FarmaMed.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FarmaMed.Infra.Repository
{
    public class MedicamentoRepository : Repository<Medicamento>, IMedicamentoRepository
    {
        public MedicamentoRepository(FarmaMedContext context) : base(context) { }

        public async Task<IEnumerable<Medicamento>> BuscarTodosMedicamentos()
        {
            return await DbSet
                .Include(medicamento => medicamento.MedicamentoSintomas)
                .ThenInclude(medicamentoSintoma => medicamentoSintoma.Sintoma)
                .ToListAsync();
        }
    }
}

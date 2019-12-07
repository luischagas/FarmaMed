using FarmaMed.DomainModel.Interfaces.Repositories;
using FarmaMed.DomainModel.MedicamentoAggregate;
using FarmaMed.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarmaMed.Infra.Repository
{
    public class MedicamentoRepository : Repository<Medicamento>, IMedicamentoRepository
    {
        public MedicamentoRepository(FarmaMedContext context) : base(context) { }
        
    }
}

using FarmaMed.DomainModel.Interfaces.Repositories;
using FarmaMed.DomainModel.MedicamentoAggregate;
using FarmaMed.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaMed.Infra.Repository
{
   public class SintomaRepository : Repository<Sintoma>, ISintomaRepository
    {
        public SintomaRepository(FarmaMedContext context) : base(context) { }

    }
}


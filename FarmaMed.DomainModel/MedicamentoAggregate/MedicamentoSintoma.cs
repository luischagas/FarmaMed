using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaMed.DomainModel.MedicamentoAggregate
{
    public class MedicamentoSintoma : EntityBase
    {
        public Guid MedicamentoId { get; set; }
        public Medicamento Medicamento { get; set; }
        public Guid SintomaId { get; set; }
        public Sintoma Sintoma { get; set; }
    }
}

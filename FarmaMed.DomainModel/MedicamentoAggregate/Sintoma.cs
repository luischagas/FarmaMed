using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaMed.DomainModel.MedicamentoAggregate
{
   public class Sintoma : EntityBase
    {
        public string Descricao { get; set; }

        public List<MedicamentoSintoma> MedicamentoSintoma { get; set; } = new List<MedicamentoSintoma>();
    }
}

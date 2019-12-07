using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaMed.DomainModel.MedicamentoAggregate
{
    public class Medicamento : EntityBase
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public List<MedicamentoSintoma> MedicamentoSintoma { get; set; } = new List<MedicamentoSintoma>();
    }
}

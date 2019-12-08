using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaMed.DomainModel.MedicamentoAggregate
{
    public class Medicamento : EntityBase
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public List<MedicamentoSintoma> MedicamentoSintomas { get; set; } = new List<MedicamentoSintoma>();
    }
}

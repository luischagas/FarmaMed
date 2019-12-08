using System;
using System.Collections.Generic;

namespace FarmaMed.API.ViewModels
{
    public class ListMedicamentoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public IEnumerable<string> Sintomas { get; set; }
    }
}

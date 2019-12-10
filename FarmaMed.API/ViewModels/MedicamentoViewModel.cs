using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaMed.API.ViewModels
{
    public class MedicamentoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public IEnumerable<SintomaViewModel> Sintomas { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaMed.API.ViewModels
{
    public class NewMedicamentoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public List<Guid> Sintomas { get; set; }
    }
}

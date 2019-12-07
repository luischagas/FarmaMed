using FarmaMed.DomainModel.MedicamentoAggregate;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FarmaMed.DomainModel.Interfaces.Services
{
    public interface ISintomaService
    {
        Task<Sintoma> BuscarSintoma(Guid id);
        Task<IEnumerable<Sintoma>> BuscarTodosSintomas();
        Task AdicionarSintoma(Sintoma sintoma);
        Task AtualizarSintoma(Sintoma sintoma);
        Task RemoverSintoma(Guid id);
    }
}

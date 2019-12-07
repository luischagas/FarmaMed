using FarmaMed.DomainModel.Interfaces.Repositories;
using FarmaMed.DomainModel.Interfaces.Services;
using FarmaMed.DomainModel.MedicamentoAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarmaMed.DomainService
{
    public class SintomaService : ISintomaService
    {
        private ISintomaRepository _sintomaRepository;

        public SintomaService(ISintomaRepository SintomaRepository)
        {
            _sintomaRepository = SintomaRepository;
        }

        public async Task AdicionarSintoma(Sintoma Sintoma)
        {
            await _sintomaRepository.Create(Sintoma);
        }

        public async Task AtualizarSintoma(Sintoma Sintoma)
        {
            await _sintomaRepository.Update(Sintoma);
        }

        public async Task RemoverSintoma(Guid sintomaId)
        {
            await _sintomaRepository.Delete(sintomaId);
        }

        public async Task<Sintoma> BuscarSintoma(Guid sintomaId)
        {
            return await _sintomaRepository.Read(sintomaId);
        }

        public async Task<IEnumerable<Sintoma>> BuscarTodosSintomas()
        {
            return await _sintomaRepository.ReadAll();
        }

        public void Dispose()
        {
            _sintomaRepository?.Dispose();
        }
    }
}

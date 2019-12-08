using FarmaMed.DomainModel.Interfaces.Repositories;
using FarmaMed.DomainModel.Interfaces.Services;
using FarmaMed.DomainModel.Interfaces.UoW;
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
        private IUnitOfWork _unitOfWork;

        public SintomaService(ISintomaRepository SintomaRepository, IUnitOfWork unitOfWork)
        {
            _sintomaRepository = SintomaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AdicionarSintoma(Sintoma Sintoma)
        {
            await _sintomaRepository.Create(Sintoma);
            await _unitOfWork.CommitAsync();
        }

        public async Task AtualizarSintoma(Sintoma Sintoma)
        {
            await _sintomaRepository.Update(Sintoma);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoverSintoma(Guid sintomaId)
        {
            await _sintomaRepository.Delete(sintomaId);
            await _unitOfWork.CommitAsync();
        }

        public async Task<Sintoma> BuscarSintoma(Guid sintomaId)
        {
            return await _sintomaRepository.Read(sintomaId);
        }

        public async Task<IEnumerable<Sintoma>> BuscarTodosSintomas()
        {
            return await _sintomaRepository.ReadAll();
        }
    }
}

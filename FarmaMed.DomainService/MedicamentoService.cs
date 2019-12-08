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
    public class MedicamentoService : IMedicamentoService
    {
        private IMedicamentoRepository _medicamentoRepository;
        private IUnitOfWork _unitOfWork;

        public MedicamentoService(IMedicamentoRepository medicamentoRepository, IUnitOfWork unitOfWork)
        {
            _medicamentoRepository = medicamentoRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AdicionarMedicamento(Medicamento medicamento)
        {
            await _medicamentoRepository.Create(medicamento);
            await _unitOfWork.CommitAsync();
        }

        public async Task AtualizarMedicamento(Medicamento medicamento)
        {
            await _medicamentoRepository.Update(medicamento);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoverMedicamento(Guid medicamentoId)
        {
            await _medicamentoRepository.Delete(medicamentoId);
            await _unitOfWork.CommitAsync();
        }

        public async Task<Medicamento> BuscarMedicamento(Guid medicamentoId)
        {
           return await _medicamentoRepository.Read(medicamentoId);
        }

        public async Task<IEnumerable<Medicamento>> BuscarTodosMedicamentos()
        {
            return await _medicamentoRepository.BuscarTodosMedicamentos();
        }
    }
}

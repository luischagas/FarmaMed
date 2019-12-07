using FarmaMed.DomainModel.Interfaces.Repositories;
using FarmaMed.DomainModel.Interfaces.Services;
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

        public MedicamentoService(IMedicamentoRepository medicamentoRepository)
        {
            _medicamentoRepository = medicamentoRepository;
        }

        public async Task AdicionarMedicamento(Medicamento medicamento)
        {
            await _medicamentoRepository.Create(medicamento);
        }

        public async Task AtualizarMedicamento(Medicamento medicamento)
        {
            await _medicamentoRepository.Update(medicamento);
        }

        public async Task RemoverMedicamento(Guid medicamentoId)
        {
            await _medicamentoRepository.Delete(medicamentoId);
        }

        public async Task<Medicamento> BuscarMedicamento(Guid medicamentoId)
        {
           return await _medicamentoRepository.Read(medicamentoId);
        }

        public async Task<IEnumerable<Medicamento>> BuscarTodosMedicamentos()
        {
            return await _medicamentoRepository.ReadAll();
        }  

        public void Dispose()
        {
            _medicamentoRepository?.Dispose();
        }
    }
}

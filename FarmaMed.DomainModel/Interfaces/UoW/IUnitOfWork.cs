using System.Threading.Tasks;

namespace FarmaMed.DomainModel.Interfaces.UoW
{
    public interface IUnitOfWork
    {
        void BeginTrasanction();
        int Commit();
        Task<int> CommitAsync();
        void Rollback();
    }
}

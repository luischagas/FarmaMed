using System.Threading.Tasks;
using FarmaMed.DomainModel.Interfaces.UoW;
using FarmaMed.Infra.Context;

namespace FarmaMed.Infra.UoW
{
    public class EntityFrameworkUnitOfWork : IUnitOfWork
    {
        private readonly FarmaMedContext _context;

        public EntityFrameworkUnitOfWork(FarmaMedContext context)
        {
            this._context = context;
        }

        public void BeginTrasanction()
        {
            _context.Database.BeginTransaction();
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Rollback()
        {
        }
    }
}

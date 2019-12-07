using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarmaMed.DomainModel.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : EntityBase
    {
        Task Create(TEntity entity);
        Task<TEntity> Read(Guid id);
        Task<IEnumerable<TEntity>> ReadAll();
        Task Update(TEntity entity);
        Task Delete(Guid id);
        Task<int> SaveChanges();
    }
}

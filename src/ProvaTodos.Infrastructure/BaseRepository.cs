using System.Linq;
using System.Threading.Tasks;
using ProvaTodos.Domain.Interfaces;

namespace ProvaTodos.Infrastructure
{
  public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
    {

        public abstract void Add(TEntity entity);
        public abstract Task AddAsync(TEntity entity);

        public abstract void Remove(TEntity entity);

        public abstract void RemoveById(object id);

        public abstract void Edit(TEntity entity);

        public abstract TEntity GetById(object id);

        public abstract Task<TEntity> GetByIdAsync(params object[] id);

        public abstract IQueryable<TEntity> GetAll();

    }
}
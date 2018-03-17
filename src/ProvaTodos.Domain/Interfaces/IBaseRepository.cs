using System.Linq;
using System.Threading.Tasks;

namespace ProvaTodos.Domain.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        void Add (TEntity entity);
        Task AddAsync (TEntity entity);

        void Remove (TEntity entity);

        void RemoveById (object id);

        void Edit (TEntity entity);

        TEntity GetById (object id);
        Task<TEntity> GetByIdAsync (params object[] id);

        IQueryable<TEntity> GetAll ();

    }
}
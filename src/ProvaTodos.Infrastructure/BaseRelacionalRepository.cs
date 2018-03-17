using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProvaTodos.Domain;

namespace ProvaTodos.Infrastructure
{
    public class BaseRelacionalRepository<TEntity> : BaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected DbSet<TEntity> DbSet;

        public BaseRelacionalRepository(DbContext context)
        {
            DbSet = context.Set<TEntity>();
        }

        public override void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public override Task AddAsync(TEntity entity)
        {
            return DbSet.AddAsync(entity);
        }

        public override void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public override void RemoveById(object id)
        {
            var entity = this.GetById(id);

            if (entity != null)
            {
                this.DbSet.Remove(entity);
            }
        }

        public override void Edit(TEntity entity)
        {
            this.DbSet.Update(entity);
        }

        public override TEntity GetById(object id)
        {
            return this.DbSet.Find(id);
        }

        public override Task<TEntity> GetByIdAsync(params object[] id)
        {
            return this.DbSet.FindAsync(id);
        }

        public override IQueryable<TEntity> GetAll()
        {
            return this.DbSet;
        }
    }
}
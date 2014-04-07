using System.Data.Entity;
using System.Linq;

namespace Nt.Dao
{
    public interface IRepository<TEntity> where TEntity : class
    {
        DbContext DbContext { get; set; }
        DbSet<TEntity> DbSet { get; set; }
        IQueryable<TEntity> GetQuery();
        TEntity Get(object id);
        TEntity Add(TEntity entity);
        TEntity Edit(TEntity entity);
        TEntity Delete(TEntity entity);
        int SaveChanges();
    }
}

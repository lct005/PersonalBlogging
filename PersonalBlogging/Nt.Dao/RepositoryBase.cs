using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Nt.Dao
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public System.Data.Entity.DbContext DbContext { get; set; }
        public System.Data.Entity.DbSet<TEntity> DbSet { get; set; }

        public RepositoryBase(DbContext dbContext)
        {
            this.DbContext = dbContext;
            this.DbSet = this.DbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetQuery()
        {
            return this.DbSet;
        }

        public TEntity Get(object id)
        {
            return this.DbSet.Find(id);
        }

        public TEntity Add(TEntity entity)
        {
            Contract.Requires(entity != null);

            DbEntityEntry<TEntity> entityEntry = this.DbContext.Entry<TEntity>(entity);
            if (entityEntry.State != EntityState.Detached)
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.DbSet.Add(entity);
            }
            return entity;
        }

        public TEntity Edit(TEntity entity)
        {
            Contract.Requires(entity != null);

            DbEntityEntry<TEntity> entityEntry = this.DbContext.Entry<TEntity>(entity);
            if (entityEntry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }
            entityEntry.State = EntityState.Modified;

            return entity;
        }


        public TEntity Delete(TEntity entity)
        {
            Contract.Requires(entity != null);

            DbEntityEntry<TEntity> entityEntry = this.DbContext.Entry<TEntity>(entity);
            if ((entityEntry.State == EntityState.Detached))
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.DbSet.Attach(entity);
                this.DbSet.Remove(entity);
            }

            return entity;
        }

        public int SaveChanges()
        {
            return this.DbContext.SaveChanges();
        }

    }
}

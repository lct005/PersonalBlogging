using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nt.Dao;
using PersonalBlogging.Service.Interfaces;

namespace PersonalBlogging.Service
{
    public class ServiceBase<TEntity> : IService<TEntity> where TEntity : class
    {
        private IRepository<TEntity> entitRepository;

        public ServiceBase(IRepository<TEntity> entitRepository)
        {
            this.entitRepository = entitRepository;
        }

        public IQueryable<TEntity> GetQuery()
        {
            return this.entitRepository.GetQuery();
        }

        public TEntity Get(object id)
        {
            return this.entitRepository.Get(id);
        }

        public TEntity Add(TEntity entity)
        {
            return this.entitRepository.Add(entity);
        }

        public TEntity Edit(TEntity entity)
        {
            return this.entitRepository.Edit(entity);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlogging.Service.Interfaces
{
    interface IService<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetQuery();
        TEntity Get(object id);
        TEntity Add(TEntity entity);
        TEntity Edit(TEntity entity);
    }
}

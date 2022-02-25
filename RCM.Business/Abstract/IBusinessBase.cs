using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RCM.Business.Abstract
{
    public interface IBusinessBase<TEntity>
    {
        //ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);

        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params string[] includeList);

        //TEntity Get(Expression<Func<TEntity, bool>> filter=null);
        TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includeList);

        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);


        //TEntity GetById(int id, params string[] includeList);
        //void Delete(int id);
    }
}

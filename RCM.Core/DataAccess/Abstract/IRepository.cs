using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Core.DataAccess.Abstract
{
    public interface IRepository<T> where T: BaseDomain , new()
    
    {
        //ICollection<T> GetAll(Expression<Func<T, bool>> filter = null);
        ICollection<T> GetAll(Expression<Func<T, bool>> filter = null, params string[] includeList);

        //T Get(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter, params string[] includeList);

        T Insert(T entity);
        T Update(T entity);
        void Delete(T entity);

        //T GetById(int id, params string[] includeList);

        //void Delete(int id);
    }
}

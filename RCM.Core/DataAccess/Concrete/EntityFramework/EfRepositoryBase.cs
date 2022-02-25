using Core.DataAccess.Abstract;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Net;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfRepositoryBase<TContext, TEntity> : IRepository<TEntity>
        where TEntity : BaseDomain, new()
        where TContext : DbContext, new()
    {

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includeList)
        {
            try
            {
                using (TContext ctx = new TContext())
                {
                    IQueryable<TEntity> query = ctx.Set<TEntity>();

                    if (includeList != null)
                    {
                        for (int i = 0; i < includeList.Length; i++)
                        {
                            query = query.Include(includeList[i]);
                        }
                    }

                    return query.SingleOrDefault(filter);
                }
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (IndexOutOfRangeException)
            {
                throw;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (WebException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }


        }
        
        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params string[] includeList)
        {
            try { 

            using (TContext ctx = new TContext())
            {
                IQueryable<TEntity> query = filter == null
                    ? ctx.Set<TEntity>()
                    : ctx.Set<TEntity>().Where(filter);

                if (includeList != null)
                {
                    for (int i = 0; i < includeList.Length; i++)
                    {
                        query = query.Include(includeList[i]);
                    }
                }

                return query.ToList();
            }
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (IndexOutOfRangeException)
            {
                throw;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (WebException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TEntity Insert(TEntity entity)
        {
            try 
            { 
            using (TContext ctx = new TContext())
            {
                TEntity addedEntity = ctx.Set<TEntity>().Add(entity);
                ctx.SaveChanges();

                return addedEntity;
            }
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (IndexOutOfRangeException)
            {
                throw;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (WebException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TEntity Update(TEntity entity)
        {
            try 
            {
            using (TContext ctx = new TContext())
            {
                ctx.Set<TEntity>().Attach(entity);
                ctx.Entry(entity).State = EntityState.Modified;
                ctx.SaveChanges();

                return entity;
            }
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (IndexOutOfRangeException)
            {
                throw;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (WebException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(TEntity entity)
        {
            try 
            {
            using (TContext ctx = new TContext())
            {
                if (ctx.Entry(entity).State == EntityState.Detached)
                    ctx.Set<TEntity>().Attach(entity);

                ctx.Set<TEntity>().Remove(entity);
                ctx.SaveChanges();
            }
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (IndexOutOfRangeException)
            {
                throw;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (WebException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }



        
    }
}


//----------ALL Methods without Params[]---------------
//public TEntity Get(Expression<Func<TEntity, bool>> filter=null)
//{
//    using (TContext ctx = new TContext())
//    {

//        return ctx.Set<TEntity>().SingleOrDefault(filter);


//    }
//}



//public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
//{
//    using (TContext ctx = new TContext())
//    {
//        if (filter != null)
//          return  ctx.Set<TEntity>().Where(filter).ToList();

//        else
//            return ctx.Set<TEntity>().ToList();

//    }
//}


//public void Delete(int id)
//{
//    using (TContext ctx = new TContext())
//    {
//        TEntity entity = this.Get(x => x.Id == id);
//        this.Delete(entity);
//    }
//}

//public TEntity GetById(int id, params string[] includeList)
//{
//    return Get(x=> x.Id == id, includeList);
//}
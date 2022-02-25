using Core.DataAccess.Abstract;
using RCM.Business.Abstract;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentValidation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using System.Data.SqlClient;
using System.Net;

namespace RCM.Business.Concrete
{
    public class BusinessBase<TEntity> : IBusinessBase<TEntity>
        where TEntity : BaseDomain, new()
    {
        IRepository<TEntity> _repo;

        public BusinessBase(IRepository<TEntity> repo)
        {
            _repo = repo;
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includeList)
        {
            try
            {
            return _repo.Get(filter, includeList);
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch(ArgumentNullException)
            {
                throw;
            }
            catch(ArgumentOutOfRangeException)
            {
                throw;
            }
            catch(ArgumentException)
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

        public virtual ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params string[] includeList)
        {
            try 
            {
            return _repo.GetAll(filter, includeList);
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
        
        public virtual TEntity Insert(TEntity entity)
        {

            Type type = Type.GetType("RCM.Business.ValidationRules.FluentValidation.Domain." + entity.GetType().Name + "Validator");

            AbstractValidator<TEntity> validatorObj = Activator.CreateInstance(type) as AbstractValidator<TEntity>;

            try
            {
                ValidationTool<TEntity>.Validate(validatorObj, entity);

                return _repo.Insert(entity);
            }
            catch(ValidationException)
            {
                throw;
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

            //return _repo.Insert(entity);

        }

        public virtual TEntity Update(TEntity entity)
        {
            Type type = Type.GetType("RCM.Business.ValidationRules.FluentValidation.Domain." + entity.GetType().Name + "Validator");

            AbstractValidator<TEntity> validatorObj = Activator.CreateInstance(type) as AbstractValidator<TEntity>;

            try
            {
                ValidationTool<TEntity>.Validate(validatorObj, entity);
                return _repo.Update(entity);
            }
            catch (ValidationException)
            {
                throw;
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

        public virtual void Delete(TEntity entity)
        {
            try
            {
            _repo.Delete(entity);
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
//public virtual TEntity Get(Expression<Func<TEntity, bool>> filter=null)
//{
//    return _repo.Get(filter);
//}

//public virtual ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
//{
//    return _repo.GetAll(filter);
//}


//public virtual void Delete(int id)
//{
//    _repo.Delete(id);
//}

//public TEntity GetById(int id, params string[] includeList)
//{
//    return Get(x => x.Id == id, includeList);
//}
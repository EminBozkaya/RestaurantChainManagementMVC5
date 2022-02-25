using FluentValidation;
using Ninject;
using Ninject.Modules;
using System;

namespace Core.Utilities.MVC.IoC.Ninject
{
    public class NinjectValidatorFactory : ValidatorFactoryBase
    {
        private IKernel _kernel;
        public NinjectValidatorFactory(INinjectModule module)
        {
            _kernel = new StandardKernel(module);
        }

        public override IValidator CreateInstance(Type validatorType)
        {
            
                return (IValidator)_kernel.Get(validatorType);
                //return _kernel.GetService(typeof(IValidator<>).MakeGenericType(validatorType)) as IValidator;
            
        }

    }

    //private readonly IKernel m_NInjectKernel;
    //public NinjectValidatorFactory(IKernel kernel)
    //{
    //    if (kernel == null)
    //        throw new ArgumentNullException("NInject kernel injected is null!!");

    //    m_NInjectKernel = kernel;
    //}
    //public override IValidator CreateInstance(Type validatorType)
    //{
    //    return m_NInjectKernel.Get(validatorType) as IValidator;
    //}





    //public IValidator GetValidator(Type type)
    //{
    //    if (type == null)
    //    {
    //        throw new ArgumentNullException("type");
    //    }
    //    return DependencyResolver.Current.GetService(typeof(IValidator<>).MakeGenericType(type)) as IValidator;
    //}

    //public IValidator<T> GetValidator<T>()
    //{
    //    return DependencyResolver.Current.GetService<IValidator<T>>();
    //}




}

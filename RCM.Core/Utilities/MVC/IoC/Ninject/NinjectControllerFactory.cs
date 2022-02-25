using System;
using System.Web.Mvc;
using Ninject;
using Ninject.Modules;
using System.Web.Routing;

namespace Core.Utilities.Mvc.IoC.Ninject
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _kernel;
        public NinjectControllerFactory(INinjectModule module)
        {
            _kernel = new StandardKernel(module);
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
                return (IController)_kernel.Get(controllerType);
        }

    }
}

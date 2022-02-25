using Core.Utilities.Mvc.IoC.Ninject;
using RCM.Business.DependencyResolvers.Ninject;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FluentValidation.Mvc;

namespace RCM.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new NinjectBussinessModule()));


            ModelValidatorProviders.Providers.Clear();

            //ModelValidatorProviders.Providers.Add(new FluentValidationModelValidatorProvider
            //{
            //    AddImplicitRequiredValidator = true
            //});


            FluentValidationModelValidatorProvider.Configure(provider =>
            {
                provider.ValidatorFactory = new Core.Utilities.MVC.IoC.Ninject.NinjectValidatorFactory(new NinjectValidationModule());
                //provider.AddImplicitRequiredValidator = true;
            });

            //Tell MVC to use FV for validation
            //ModelValidatorProviders.Providers.Add(new FluentValidationModelValidatorProvider(new NinjectValidatorFactory(new NinjectValidationModule())));
            //DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;


            //FluentValidationModelValidatorProvider.Configure(provider =>
            //{
            //    provider.ValidatorFactory = new NinjectValidatorFactory(new NinjectValidationModule());
            //    //provider.AddImplicitRequiredValidator = true;
            //});


            //ModelValidatorProviders.Providers.Clear();








            // for client side (fluentvalidation)
            //ModelValidatorProviders.Providers.Clear();
            //ModelValidatorProviders.Providers.Add(new FluentValidationModelValidatorProvider());
            //FluentValidationModelValidatorProvider.Configure();
            //DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;


            //Configure structuremap


            //Configure FV to use StructureMap






            //IKernel krnl = new StandardKernel();

            //ModelValidatorProviders.Providers.Add(new FluentValidationModelValidatorProvider(new NinjectValidatorFactory(krnl)));
            //DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;




        }
    }
}

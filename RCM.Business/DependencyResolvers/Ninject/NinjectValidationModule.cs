using FluentValidation;
using Ninject.Modules;
using RCM.Business.ValidationRules.FluentValidation.Complex.Fake;
using RCM.Business.ValidationRules.FluentValidation.Complex.Ruled;
using RCM.Business.ValidationRules.FluentValidation.Domain;
using RCM.Model.Complex.DashBoard.ChangesByUser.UserInfo;
using RCM.Model.Complex.DashBoard.SystemManagement.User;
using RCM.Model.Complex.Login;
using RCM.Model.Domain;
using RCM.Model.Multiple;

namespace RCM.Business.DependencyResolvers.Ninject
{
    public class NinjectValidationModule : NinjectModule
    {
        public override void Load()
        {
            //-----------------------Domain-------------------------------------

            Bind<IValidator<User>>().To<UserValidator>();
            Bind<IValidator<UserBranchAuthority>>().To<UserBranchAuthorityValidator>();
            


            //-----------------------Complex--------------------------------------

            Bind<IValidator<LogInVm>>().To<LogInVmValidator>();
            Bind<IValidator<ForgotPasswordVm>>().To<ForgotPasswordVmValidator>();
            Bind<IValidator<CreateNewUserVm>>().To<CreateNewUserVmValidator>();
            Bind<IValidator<ProfileEditVm>>().To<ProfileEditVmValidator>();
            Bind<IValidator<UpdateUserVm>>().To<UpdateUserVmValidator>();




            //-------------Not Used but NEED (Fake Bindings)-----------
            Bind<IValidator<ActiveBranchInfoVm>>().To<ActiveBranchInfoVmValidator>();
            Bind<IValidator<SetUserInfoVm>>().To<SetUserInfoVmValidator>();




        }
    }
}

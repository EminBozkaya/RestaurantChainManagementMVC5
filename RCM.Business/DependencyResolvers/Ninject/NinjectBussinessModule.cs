
using Ninject.Modules;
using RCM.DataAccess.Abstract;
using RCM.DataAccess.Concrete.EntityFramework.Repositories;

namespace RCM.Business.DependencyResolvers.Ninject
{
    public class NinjectBussinessModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<IAdressOfCustomerBs>().To<AdressOfCustomerBs>();


            //Bind<IAdressOfCustomerRepo>().To<EfAdressOfCustomerRepo>();
            Bind<IAuthorityTypeRepo>().To<EfAuthorityTypeRepo>();
            Bind<IBranchRepo>().To<EfBranchRepo>();
            //Bind<IBranchCaseTypeRepo>().To<EfBranchCaseTypeRepo>();
            //Bind<IBranchCaseTypeFlowRepo>().To<EfBranchCaseTypeFlowRepo>();
            //Bind<IBranchConsumptionRepo>().To<EfBranchConsumptionRepo>();
            //Bind<IBranchCreditCardRepo>().To<EfBranchCreditCardRepo>();
            //Bind<IBranchCreditCardFlowRepo>().To<EfBranchCreditCardFlowRepo>();
            //Bind<IBranchDailyRevenueRepo>().To<EfBranchDailyRevenueRepo>();
            //Bind<IBranchProductPriceRepo>().To<EfBranchProductPriceRepo>();
            //Bind<IBranchRevenueDistributionRepo>().To<EfBranchRevenueDistributionRepo>();
            //Bind<IBranchStockRepo>().To<EfBranchStockRepo>();
            //Bind<IBranchStockEntryRepo>().To<EfBranchStockEntryRepo>();
            //Bind<ICaseTypeRepo>().To<EfCaseTypeRepo>();
            //Bind<IConsumeTypeRepo>().To<EfConsumeTypeRepo>();
            //Bind<ICreditCardRepo>().To<EfCreditCardRepo>();
            //Bind<ICustomerRepo>().To<EfCustomerRepo>();
            //Bind<IEmployeeRepo>().To<EfEmployeeRepo>();
            //Bind<IEmployeeMoneyFlowRepo>().To<EfEmployeeMoneyFlowRepo>();
            //Bind<IEmployeePaymentTypeRepo>().To<EfEmployeePaymentTypeRepo>();
            //Bind<IEmployeeRollCallRepo>().To<EfEmployeeRollCallRepo>();
            //Bind<IExpenseFlowRepo>().To<EfExpenseFlowRepo>();
            //Bind<IExpenseTypeRepo>().To<EfExpenseTypeRepo>();
            //Bind<IFirmTypeRepo>().To<EfFirmTypeRepo>();
            Bind<IMyExceptionRepo>().To<EfMyExceptionRepo>();

            //Bind<IPositionTypeRepo>().To<EfPositionTypeRepo>();
            //Bind<IProductRepo>().To<EfProductRepo>();
            //Bind<IProductCategoryRepo>().To<EfProductCategoryRepo>();
            //Bind<IProductPhotoRepo>().To<EfProductPhotoRepo>();
            //Bind<IRawMaterialRepo>().To<EfRawMaterialRepo>();
            //Bind<IRollCallTypeRepo>().To<EfRollCallTypeRepo>();
            //Bind<ISalaryTypeRepo>().To<EfSalaryTypeRepo>();
            //Bind<ISaleRepo>().To<EfSaleRepo>();
            //Bind<ISaleNoteCategoryRepo>().To<EfSaleNoteCategoryRepo>();
            //Bind<ISaleNoteRepo>().To<EfSaleNoteRepo>();
            //Bind<ISaleNoteOfProductRepo>().To<EfSaleNoteOfProductRepo>();
            //Bind<ISaleTypeRepo>().To<EfSaleTypeRepo>();
            //Bind<ISupplierRepo>().To<EfSupplierRepo>();
            //Bind<ISupplierMoneyFlowRepo>().To<EfSupplierMoneyFlowRepo>();
            Bind<IUserRepo>().To<EfUserRepo>();
            Bind<IUserBranchAuthorityRepo>().To<EfUserBranchAuthorityRepo>();
            //Bind<IWorkTypeRepo>().To<EfWorkTypeRepo>();
            //Bind<IRawMaterialOfProductRepo>().To<EfRawMaterialOfProductRepo>();
            //Bind<IRawMaterialOfSupplierRepo>().To<EfRawMaterialOfSupplierRepo>();
            //Bind<ISaleDetailRepo>().To<EfSaleDetailRepo>();

        }
    }
}

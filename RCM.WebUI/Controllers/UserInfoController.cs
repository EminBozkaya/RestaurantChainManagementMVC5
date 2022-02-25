using Core.Utilities.Common;
using RCM.Business.Concrete;
using RCM.Model.Complex.DashBoard.ChangesByUser.UserInfo;
using RCM.Model.Domain;
using RCM.WebUI.MvcHelper;
using RCM.WebUI.MvcHelper.Filters;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;
using System.Web.Mvc;

namespace RCM.WebUI.Controllers
{
    [SessionRequired]
    public class UserInfoController : Controller
    {
        #region My Fields here

        //private readonly AdressOfCustomerBs _adressOfCustomerBs;
        private readonly AuthorityTypeBs _authorityTypeBs;
        private readonly BranchBs _branchBs;
        //private readonly BranchCaseTypeBs _branchCaseTypeBs;
        //private readonly BranchCaseTypeFlowBs _branchCaseTypeFlowBs;
        //private readonly BranchConsumptionBs _branchConsumptionBs;
        //private readonly BranchCreditCardBs _branchCreditCardBs;
        //private readonly BranchCreditCardFlowBs _branchCreditCardFlowBs;
        //private readonly BranchDailyRevenueBs _branchDailyRevenueBs;
        //private readonly BranchProductPriceBs _branchProductPriceBs;
        //private readonly BranchRevenueDistributionBs _branchRevenueDistributionBs;
        //private readonly BranchStockBs _branchStockBs;
        //private readonly BranchStockEntryBs _branchStockEntryBs;
        //private readonly CaseTypeBs _caseTypeBs;
        //private readonly ConsumeTypeBs _consumeTypeBs;
        //private readonly CreditCardBs _creditCardBs;
        //private readonly CustomerBs _customerBs;
        //private readonly EmployeeBs _employeeBs;
        //private readonly EmployeeMoneyFlowBs _employeeMoneyFlowBs;
        //private readonly EmployeePaymentTypeBs _employeePaymentTypeBs;
        //private readonly EmployeeRollCallBs _employeeRollCallBs;
        //private readonly ExpenseFlowBs _expenseFlowBs;
        //private readonly ExpenseTypeBs _expenseTypeBs;
        //private readonly FirmTypeBs _firmTypeBs;
        //private readonly PositionTypeBs _positionTypeBs;
        //private readonly ProductBs _productBs;
        //private readonly ProductCategoryBs _productCategoryBs;
        //private readonly ProductPhotoBs _productPhotoBs;
        //private readonly RawMaterialBs _rawMaterialBs;
        //private readonly RollCallTypeBs _rollCallTypeBs;
        //private readonly SalaryTypeBs _salaryTypeBs;
        //private readonly SaleBs _saleBs;
        //private readonly SaleNoteBs _saleNoteBs;
        //private readonly SaleNoteOfProductBs _saleNoteOfProductBs;
        //private readonly SaleTypeBs _saleTypeBs;
        //private readonly SupplierBs _supplierBs;
        //private readonly SupplierMoneyFlowBs _supplierMoneyFlowBs;
        private readonly UserBs _userBs;
        private readonly UserBranchAuthorityBs _userBranchAuthorityBs;
        //private readonly WorkTypeBs _workTypeBs;
        //private readonly RawMaterialOfProductBs _rawMaterialOfProductBs;
        //private readonly RawMaterialOfSupplierBs _rawMaterialOfSupplierBs;
        //private readonly SaleDetailBs _saleDetailBs;

        #endregion
        public UserInfoController(

        #region My Constructor Datas

            //AdressOfCustomerBs adressOfCustomerBs, 
            AuthorityTypeBs authorityTypeBs,
            BranchBs branchBs,
            //BranchCaseTypeBs branchCaseTypeBs, 
            //BranchCaseTypeFlowBs branchCaseTypeFlowBs, 
            //BranchConsumptionBs branchConsumptionBs, 
            //BranchCreditCardBs branchCreditCardBs, 
            //BranchCreditCardFlowBs branchCreditCardFlowBs, 
            //BranchDailyRevenueBs branchDailyRevenueBs, 
            //BranchProductPriceBs branchProductPriceBs, 
            //BranchRevenueDistributionBs branchRevenueDistributionBs, 
            //BranchStockBs branchStockBs, 
            //BranchStockEntryBs branchStockEntryBs, 
            //CaseTypeBs caseTypeBs, 
            //ConsumeTypeBs consumeTypeBs, 
            //CreditCardBs creditCardBs, 
            //CustomerBs customerBs, 
            //EmployeeBs employeeBs, 
            //EmployeeMoneyFlowBs employeeMoneyFlowBs, 
            //EmployeePaymentTypeBs employeePaymentTypeBs, 
            //EmployeeRollCallBs employeeRollCallBs, 
            //ExpenseFlowBs expenseFlowBs, 
            //ExpenseTypeBs expenseTypeBs, 
            //FirmTypeBs firmTypeBs, 
            //PositionTypeBs positionTypeBs, 
            //ProductBs productBs, 
            //ProductCategoryBs productCategoryBs, 
            //ProductPhotoBs productPhotoBs, 
            //RawMaterialBs rawMaterialBs, 
            //RollCallTypeBs rollCallTypeBs, 
            //SalaryTypeBs salaryTypeBs, 
            //SaleBs saleBs, 
            //SaleNoteBs saleNoteBs, 
            //SaleNoteOfProductBs saleNoteOfProductBs, 
            //SaleTypeBs saleTypeBs, 
            //SupplierBs supplierBs, 
            //SupplierMoneyFlowBs supplierMoneyFlowBs, 
            UserBs userBs,
            UserBranchAuthorityBs userBranchAuthorityBs
            //WorkTypeBs workTypeBs, 
            //RawMaterialOfProductBs rawMaterialOfProductBs, 
            //RawMaterialOfSupplierBs rawMaterialOfSupplierBs, 
            //SaleDetailBs saleDetailBs
        #endregion

            )
        {
            #region Setting Constructor Variables to My Fields Here

            //_adressOfCustomerBs = adressOfCustomerBs;
            _authorityTypeBs = authorityTypeBs;
            _branchBs = branchBs;
            //_branchCaseTypeBs = branchCaseTypeBs;
            //_branchCaseTypeFlowBs = branchCaseTypeFlowBs;
            //_branchConsumptionBs = branchConsumptionBs;
            //_branchCreditCardBs = branchCreditCardBs;
            //_branchCreditCardFlowBs = branchCreditCardFlowBs;
            //_branchDailyRevenueBs = branchDailyRevenueBs;
            //_branchProductPriceBs = branchProductPriceBs;
            //_branchRevenueDistributionBs = branchRevenueDistributionBs;
            //_branchStockBs = branchStockBs;
            //_branchStockEntryBs = branchStockEntryBs;
            //_caseTypeBs = caseTypeBs;
            //_consumeTypeBs = consumeTypeBs;
            //_creditCardBs = creditCardBs;
            //_customerBs = customerBs;
            //_employeeBs = employeeBs;
            //_employeeMoneyFlowBs = employeeMoneyFlowBs;
            //_employeePaymentTypeBs = employeePaymentTypeBs;
            //_employeeRollCallBs = employeeRollCallBs;
            //_expenseFlowBs = expenseFlowBs;
            //_expenseTypeBs = expenseTypeBs;
            //_firmTypeBs = firmTypeBs;
            //_positionTypeBs = positionTypeBs;
            //_productBs = productBs;
            //_productCategoryBs = productCategoryBs;
            //_productPhotoBs = productPhotoBs;
            //_rawMaterialBs = rawMaterialBs;
            //_rollCallTypeBs = rollCallTypeBs;
            //_salaryTypeBs = salaryTypeBs;
            //_saleBs = saleBs;
            //_saleNoteBs = saleNoteBs;
            //_saleNoteOfProductBs = saleNoteOfProductBs;
            //_saleTypeBs = saleTypeBs;
            //_supplierBs = supplierBs;
            //_supplierMoneyFlowBs = supplierMoneyFlowBs;
            _userBs = userBs;
            _userBranchAuthorityBs = userBranchAuthorityBs;
            //_workTypeBs = workTypeBs;
            //_rawMaterialOfProductBs = rawMaterialOfProductBs;
            //_rawMaterialOfSupplierBs = rawMaterialOfSupplierBs;
            //_saleDetailBs = saleDetailBs;

            #endregion
        }



        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetActiveUserInfo(int Id)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            User activeUser = new User();
            try
            {
                activeUser = _userBs.Get(x => x.UId == Id);
            }
            catch (Exception ex)
            {
                return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Sistemde Sorun Oluştu, Tekrar Deneyin" });
            }

            string username = activeUser.UserName;
            string email = activeUser.Email;
            string passwd = CryptoHelper.AESDecrypt(activeUser.Password, appSettings["Key"]);

            return Json(new { Result = true, UserName = username, Email = email, Passwd = passwd });
        }

        [HttpPost]
        public JsonResult ChangeActiveBranchInfo(ActiveBranchInfoVm vm)
        {
            try
            {
                SessionManager.ActiveUserBranchID = vm.ActiveBranchId;
                SessionManager.ActiveUserBranchName = vm.ActiveBranchName;
                SessionManager.ActiveUserAuthorityTypeID = vm.ActiveAuthorityId;
            }
            catch (Exception ex)
            {
                return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Sistemde Sorun Oluştu, Tekrar Deneyin" });
            }

            return Json(new { Result = true});
        }

        [HttpPost]
        public JsonResult UpdateUserProfile(ProfileEditVm vm)
        {
            if (ModelState.IsValid) 
            {
                NameValueCollection appSettings = ConfigurationManager.AppSettings;
                User adminUser = new User();
                User updatedActiveUser = new User();
                try
                {
                    adminUser = _userBs.Get(x => x.UId == vm.Id);
                }
                catch (Exception ex)
                {
                    return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Sistemde Sorun Oluştu, Tekrar Deneyin" });
                }

                adminUser.UserName = vm.UserName;
                adminUser.Email = vm.Email;
                adminUser.Password = CryptoHelper.AESEncrypt(vm.Password, appSettings["Key"]);
                adminUser.ModifiedTime = DateTime.Today;
                try
                {
                    updatedActiveUser=_userBs.Update(adminUser);
                    SessionManager.ActiveUser = updatedActiveUser;
                }
                catch (Exception ex)
                {
                    return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Sistemde Sorun Oluştu, Tekrar Deneyin" });
                }
                
                ModelState.Clear();

                return Json(new { Result = true, Message = "Bilgileriniz güncellendi" });

            }
            else
            {
                StringBuilder errorMessages = new StringBuilder();
                foreach (ModelState item in ModelState.Values)
                {
                    foreach (ModelError error in item.Errors)
                    {
                        errorMessages.Append(error.ErrorMessage + "!" + "<br />");
                    }
                }
                string sd = errorMessages.ToString();
                return Json(new { Result = false, Message = errorMessages.ToString() });
            }
        }
    }
}
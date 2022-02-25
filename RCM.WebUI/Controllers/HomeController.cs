using Core.Utilities.Common;
using RCM.Business.Concrete;
using RCM.Model.Complex.Login;
using RCM.Model.Domain;
using RCM.WebUI.MvcHelper;
using RCM.WebUI.MvcHelper.Filters;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using System;
using System.Text;

namespace RCM.WebUI.Controllers
{
    public class HomeController : Controller
    {

        #region My Fields here

        NameValueCollection appSettings = null;

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
        //private readonly MyExceptionBs _myExceptionBs;
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

        //Constructor -👇-
        public HomeController(

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
            //MyExceptionBs myExceptionBs,
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

            appSettings = ConfigurationManager.AppSettings;

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
            //_myExceptionBs = myExceptionBs;
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


        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public JsonResult LogIn(LogInVm vm)
        {
            //LogInVmValidator lvml = new LogInVmValidator();
            //ValidationResult result = lvml.Validate(vm);
            //if (result.IsValid)

            StringBuilder errorMessages = new StringBuilder();

            if (ModelState.IsValid)
            {
                User adminUser = new User();
                List<UserBranchAuthority> UBAs = new List<UserBranchAuthority>();
                string encryptPassword = CryptoHelper.AESEncrypt(vm.Password, appSettings["Key"]);
                try
                {
                    adminUser = _userBs.Get(x => x.UserName == vm.UserName && x.Password == encryptPassword && x.IsActive == true/*, "UserBranchAuthorities", "UserBranchAuthorities.AuthorityType", "UserBranchAuthorities.Branch"*/);//for LINQ if used
                }
                catch (Exception ex)
                {
                    return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Login İşleminde sorun Oluştu" }); 
                }

                if (adminUser != null)
                {
                    List<Branch> userBranchs = new List<Branch>();
                    List<short> userBranchIds = new List<short>();
                    List<string> userBranchNames = new List<string>();
                    List<byte> userAuthorityTypeIds = new List<byte>();
                    short bid = 0;
                    try
                    {
                        UBAs = _userBranchAuthorityBs.GetAll(x => x.UId == adminUser.UId && x.IsActive == true).ToList();
                    }
                    catch (Exception ex)
                    {
                        return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Login İşleminde sorun Oluştu" });
                    }

                    for (int i = 0; i < UBAs.Count; i++)
                    {
                        userBranchIds.Add(UBAs[i].BId);
                        userAuthorityTypeIds.Add(UBAs[i].ATId);
                        bid = UBAs[i].BId;
                        userBranchs.Add(_branchBs.Get(x => x.BId == bid));
                        userBranchNames.Add(userBranchs[i].Name);
                    }

                    //-------------with LINQ-----------------------------
                    //userBranchs = adminUser.UserBranchAuthorities.Where(x=> x.IsActive==true).Select(x => x.Branch).ToList();
                    //userBranchIds = adminUser.UserBranchAuthorities.Where(x => x.IsActive == true).Select(x => x.Branch.BId).ToList();
                    //userBranchNames = adminUser.UserBranchAuthorities.Where(x => x.IsActive == true).Select(x => x.Branch.Name).ToList();
                    //userAuthorityTypeIds = adminUser.UserBranchAuthorities.Where(x => x.IsActive == true).Select(x => x.ATId).ToList();

                    SessionManager.ActiveUser = adminUser;
                    SessionManager.ActiveUserBranchNames = userBranchNames;
                    SessionManager.ActiveUserBranchIds = userBranchIds;
                    SessionManager.ActiveUserAuthorityTypeIds = userAuthorityTypeIds;

                    //---maybe need later..
                    //SessionManager.ActiveUserEmail = adminUser.Email;
                    //SessionManager.UserBranchs = userBranchs;
                    //SessionManager.UserBranchAuthorities = UBAs;
                    //SessionManager.ActiveUserId = adminUser.UId;
                    //SessionManager.ActiveUserUserName = adminUser.UserName;

                    return Json(new { Result = true, UserBranchNames = userBranchNames, UserBranchIds = userBranchIds, AuthorityTypeIds = userAuthorityTypeIds });
                }
                return Json(new { Result = false, Message = "Böyle bir kullanıcı bulunamadı", Title="Hatalı Giriş!" });

            }
            else
            {
                foreach (ModelState item in ModelState.Values)
                {
                    foreach (ModelError error in item.Errors)
                    {
                        errorMessages.Append(error.ErrorMessage + "!" + "<br />");
                    }
                }
                return Json(new { Result = false, Message = errorMessages.ToString()});
            }

            //else
            //{
            //    string s = "";
            //    for (int i = 0; i < result.Errors.Count; i++)
            //    {
            //        s += result.Errors[i].ErrorMessage + ",";
            //    }
            //    return Json(new { Result = false, Message = s });
            //}

        }

        [SessionRequired]
        [HttpPost]
        public JsonResult LogInDefineBranchIdAndAuthorityTypeId(SetUserInfoVm vm)
        {
            SessionManager.ActiveUserBranchName = vm.activeBranchName;
            SessionManager.ActiveUserBranchID = vm.activeBranchId;
            SessionManager.ActiveUserAuthorityTypeID = vm.activeAuthrtyTypID;

            return Json(new { Result = true, });
        }
        public ActionResult LogOut()
        {
            //SessionManager.ActiveAdmin = null;
            Session.Clear();
            //Session.Abandon();

            return RedirectToAction("LogIn");
        }
        public JsonResult ForgotPassword(ForgotPasswordVm vm)
        {
            StringBuilder errorMessages = new StringBuilder();
            User adminUser = new User();

            if (ModelState.IsValid)

            {
                try
                {
                    adminUser = _userBs.Get(x => x.FirstName == vm.FirstName && x.LastName == vm.LastName && x.Email == vm.Email && x.IsActive == true);
                }
                catch (Exception ex)
                {
                    return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Bilgi Eşleştirmede Sistemsel Sorun Oluştu" });
                }

                if (adminUser != null)
                {
                    string newPassword = RandomValueGenerator.GenerateRandomGuid(4);
                    string newUserName = RandomValueGenerator.GenerateRandomGuid(4);
                    string body = string.Format("Sayın <b>{0} {1}</b><br />Kullanıcı Adınız : {2}<br />Şifreniz : {3}", vm.FirstName, vm.LastName, newUserName, newPassword);

                    try
                    {
                        MailHelper.SendMail("Yeni Şifreniz", body, vm.Email);
                    }
                    catch (Exception ex)
                    {
                        return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Mail Gönderiminde Sorun Oluştu" });
                    }

                    adminUser.Password = CryptoHelper.AESEncrypt(newPassword, appSettings["Key"]);
                    adminUser.UserName = newUserName;

                    try
                    {
                        _userBs.Update(adminUser);
                    }
                    catch(Exception ex)
                    { 
                        return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Yeni Şifre ve Kullanıcı adı Güncellenirken Sistemsel Sorun Oluştu, Lütfen Tekrar Deneyin" });
                    }

                    return Json(new { Result = true, Message = "<b>Şifreniz email adresinize gönderildi</b><br /><small><b>Not: </b>Yeni bilgilerinizi gelen kutusunda göremezseniz, istenmeyen mail(junk/spam)bölümünü kontrol ediniz</small> " });
                }

                return Json(new { Result = false, Message = "Böyle bir kullanıcı bulunamadı, lütfen bilgilerinizi doğru girip tekrar deneyin veya yöneticinizle görüşün" });
            }

            else
            {
                foreach (ModelState item in ModelState.Values)
                {
                    foreach (ModelError error in item.Errors)
                    {
                        errorMessages.Append(error.ErrorMessage + "!" + "<br />");
                    }
                }
                return Json(new { Result = false, Message = errorMessages.ToString() });
            }
        }
        public ActionResult _Layout()
        {
            return View();
        }


    }
}

























































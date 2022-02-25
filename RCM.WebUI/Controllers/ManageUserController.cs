using Core.Utilities.Common;
using RCM.Business.Concrete;
using RCM.Model.Complex.Custom;
using RCM.Model.Complex.DashBoard.SystemManagement.User;
using RCM.Model.Domain;
using RCM.Model.Enums;
using RCM.WebUI.MvcHelper;
using RCM.WebUI.MvcHelper.Filters;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace RCM.WebUI.Controllers
{
    [SessionRequired]
    [RoleFilter((int)Roles.SuperAdmin)]
    public class ManageUserController : Controller
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
        public ManageUserController(

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
        public ActionResult ShowUsers()
        {
            try
            {
                List<UserListForDataTableVm> list = _userBs.GetAll()
                                .Select(x => new UserListForDataTableVm()
                                {
                                    UId = x.UId,
                                    FirstName = x.FirstName,
                                    LastName = x.LastName,
                                    UserName = x.UserName,
                                    Phone = x.Phone,
                                    Email = x.Email,
                                    Password = x.Password,
                                    IsActive = x.IsActive,
                                    CreatedTime = x.CreatedTime,
                                    ModifiedTime = x.ModifiedTime,
                                })
                                .ToList();

                SessionManager.AllUserList = list;
                SessionManager.AllBranchs = _branchBs.GetAll().ToList();
                SessionManager.AllAuthorityTypes = _authorityTypeBs.GetAll().ToList();
            }
            catch (Exception ex)
            {
                ErrorFormatVm ef = new ErrorFormatVm();
                ef.ErrorTitle = "Sayfa Yüklenirken Hata Oluştu";
                ef.ErrorMessages = CreateExceptionFormat.CreateMessage(ex);

                return View("~/Views/DashBoard/ErrorPage.cshtml", (object)ef);
            }
            return View();
        }
        public JsonResult CreateNewUser(CreateNewUserVm vm)
        {
            if (ModelState.IsValid)
            {
                User newAdminUser = new User();
                User addedUser = new User();
                int addedUserId;

                string newPassword = RandomValueGenerator.GenerateRandomGuid(4);
                string newUserName = RandomValueGenerator.GenerateRandomGuid(4);

                //----create new User---
                newAdminUser.FirstName = vm.FirstName;
                newAdminUser.LastName = vm.LastName;
                newAdminUser.UserName = newUserName;
                newAdminUser.Phone = vm.Phone;
                newAdminUser.Email = vm.Email;
                newAdminUser.Password = CryptoHelper.AESEncrypt(newPassword, appSettings["Key"]);
                newAdminUser.IsActive = true;
                newAdminUser.CreatedTime = DateTime.Today;
                newAdminUser.ModifiedTime = DateTime.Today;

                try
                {
                    addedUser = _userBs.Insert(newAdminUser);
                    addedUserId = addedUser.UId;
                }
                catch (Exception ex)
                {
                    return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Yeni Kullanıcı Veri Tabanına Kaydedilemedi!" });
                }

                //----create new UserBranchAuthority---
                UserBranchAuthority newUba = new UserBranchAuthority();

                try
                {
                    newUba.UId = addedUserId;
                    newUba.BId = short.Parse(vm.BranchID);
                    newUba.ATId = byte.Parse(vm.AuthrtyID);
                    newUba.IsActive = true;

                    _userBranchAuthorityBs.Insert(newUba);
                }
                catch (Exception ex)
                {
                    try
                    {
                        _userBs.Delete(_userBs.Get(x => x.UId == addedUserId));
                    }
                    catch (Exception iex)
                    {
                        return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(iex), Title = "Sadece Kullanıcı Bilgileri Kaydedildi, Yetkili Olduğu Şube ve Yetki Tipi Veri Tabanına Kaydedilemedi!" });
                    }

                    return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Yeni Kullanıcı Veri Tabanına Kaydedilemedi!" });
                }


                //------Send Mail to New User---------
                string body = string.Format("Sayın <b>{0} {1}</b><br />Kullanıcı Adınız : {2}<br />Şifreniz : {3}", vm.FirstName, vm.LastName, newUserName, newPassword);
                try
                {
                    MailHelper.SendMail("Hoş geldiniz", body, vm.Email);
                }
                catch (Exception ex)
                {
                    return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Kullanıcı Kaydedildi Fakat Mail Gönderiminde Sorun Oluştu" });
                }

                return Json(new { Result = true, Message = "Yeni kullanıcı kaydedildi", Lastid = addedUserId, Username = newUserName, Password = newPassword });
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
        public JsonResult UpdateUser(UpdateUserVm vm)
        {
            if (ModelState.IsValid)
            {
                User adminUser = new User();
                try
                {
                    adminUser = _userBs.Get(x => x.UId == vm.Id);
                }
                catch (Exception ex)
                {
                    return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Kullanıcı Güncellenemedi !!" });
                }
                adminUser.FirstName = vm.FirstName;
                adminUser.LastName = vm.LastName;
                adminUser.UserName = vm.UserName;
                adminUser.Email = vm.Email;
                adminUser.Phone = vm.Phone;
                adminUser.Password = CryptoHelper.AESEncrypt(vm.Password, appSettings["Key"]);
                adminUser.IsActive = vm.State;
                adminUser.ModifiedTime = DateTime.Today;
                try
                {
                    _userBs.Update(adminUser);
                }
                catch (Exception ex)
                {
                    return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Kullanıcı Güncellenemedi !!" });
                }

                ModelState.Clear();
                return Json(new { Result = true, Message = "Kullanıcı güncellendi" });
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
        public JsonResult DeleteUser(int id)
        {
            try
            {
                _userBs.Delete(_userBs.Get(x => x.UId == id));
            }
            catch (Exception ex)
            {
                return Json(new { Result = false, Message = CreateExceptionFormat.CreateMessage(ex), Title = "Kullanıcı Silinemedi !!" });
            }
            return Json(new { Result = true });
        }


    }

}
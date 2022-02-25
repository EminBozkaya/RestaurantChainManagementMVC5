using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RCM.WebUI.MvcHelper.Filters
{
    public class RoleFilter : FilterAttribute, IActionFilter
    {
        private readonly byte[] _allowedRoleIds;
        public RoleFilter(params byte[] allowedRoleIds)
        {
            _allowedRoleIds = allowedRoleIds;
        }
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            byte roleId = SessionManager.ActiveUserAuthorityTypeID;

            //List<int> activeAdminRoleIds = activeAdmin.AdminUserRoles.Select(x => x.RoleId).ToList();

            bool isAllowed = false;

            if(_allowedRoleIds.Contains(roleId)) isAllowed = true;
            
            //for (int i = 0; i < _allowedRoleIds.Length; i++)
            //{
            //    if (activeAdminRoleIds.Contains(_allowedRoleIds[i]))
            //    {
            //        isAllowed = true;
            //        break;
            //    }
            //}

            if (isAllowed==false)
            {
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    filterContext.Result = new JsonResult()
                    {
                        Data = new { Result = false, RedirectUrl = "/DashBoard/NotAuthorized", Reason = "YetkisiYok" }
                    };

                }
                else
                {
                    filterContext.Result = new RedirectResult("/DashBoard/NotAuthorized");
                }

            }
        }
    }
}
using System.Web.Mvc;

namespace RCM.WebUI.MvcHelper.Filters
{
    public class SessionRequired : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (SessionManager.ActiveUser == null)
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    //filterContext.Result = new JsonResult()
                    //{
                    //    Data = new { Result = false, RedirectUrl = "/Home/Login", Reason = "YetkisiYok" }
                    //};
                    filterContext.Result = new RedirectResult("/Home/Login");
                }
                else
                {
                    filterContext.Result = new RedirectResult("/Home/Login");
                }
        }
        
    }
}
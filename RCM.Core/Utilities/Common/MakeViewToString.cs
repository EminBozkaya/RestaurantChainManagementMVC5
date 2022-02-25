using System.IO;
using System.Web.Mvc;

namespace Core.Utilities.Common
{
    public class RazorViewToStringFormat
    {
        /// <summary>  
        /// Render razorview to string   
        /// </summary>  
        /// <param name="controller"></param>  
        /// <param name="viewName"></param>  
        /// <param name="model"></param>  
        /// <returns></returns>  
        public static string RenderRazorViewToString(Controller controller, string viewName, object model)
        {
            controller.ViewData.Model = model;
            var viewResult = ViewEngines.Engines.FindPartialView(controller.ControllerContext, viewName);
            // checking the view inside the controller  
            if (viewResult.View != null)
            {
                using (var sw = new StringWriter())
                {
                    var viewContext = new ViewContext(controller.ControllerContext, viewResult.View, controller.ViewData, controller.TempData, sw);
                    viewResult.View.Render(viewContext, sw);
                    viewResult.ViewEngine.ReleaseView(controller.ControllerContext, viewResult.View);
                    return sw.GetStringBuilder().ToString();
                }
            }
            else
                return "View cannot be found.";
        }
    }
}

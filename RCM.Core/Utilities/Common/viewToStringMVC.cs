using System.IO;
using System.Web.Mvc;

namespace Core.Utilities.Common
{
    public class viewToStringMVC
    {
        public static string MakeViewToString<T>(Controller controller, string viewPath, T model)
        {
            controller.ViewData.Model = model;
            using (var writer = new StringWriter())
            {
                var view = new WebFormView(controller.ControllerContext, viewPath);
                var vdd = new ViewDataDictionary<T>(model);
                var viewCxt = new ViewContext(controller.ControllerContext, view, vdd,
                                            new TempDataDictionary(), writer);
                viewCxt.View.Render(viewCxt, writer);
                return writer.ToString();
            }
        }
    }
}

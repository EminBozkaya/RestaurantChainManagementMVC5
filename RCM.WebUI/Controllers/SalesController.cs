using RCM.WebUI.MvcHelper.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RCM.WebUI.Controllers
{
    [SessionRequired]
    public class SalesController : Controller
    {
        // GET: Sale
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult QuickSale()
        {
            return View();
        }
    }
}
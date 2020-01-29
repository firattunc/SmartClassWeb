using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartClass.Web.Filters
{
    public class Exc : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.Controller.TempData["lastError"] = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            filterContext.Result = new RedirectResult("/Home/HasError");
        }
    }
}
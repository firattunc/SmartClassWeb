using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartClass.Web.Filters
{
    public class Auth : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (HttpContext.Current.Session["loginUser"] == null)
            {
                filterContext.Controller.TempData["loginValid"] = "block";
                filterContext.Result = new RedirectResult("/Home/Index");
            }
        }
    }
}
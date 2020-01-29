using System;
using System.Web;
using System.Web.Mvc;

namespace SmartClass.Web.Filters
{
    public class TestFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (Convert.ToInt32(HttpContext.Current.Session["soruSayisi"]) == 0)
            {
                filterContext.Result = new RedirectResult("/Ogrenci/TestStart");
            }

        }
    }
}
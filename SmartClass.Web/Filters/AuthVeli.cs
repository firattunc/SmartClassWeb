using SmartClass.Web.Models;
using System.Web;
using System.Web.Mvc;

namespace SmartClass.Web.Filters
{
    public class AuthVeli : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if ((HttpContext.Current.Session["loginUser"] as UserModel).CurrentRoleId != 3)
            {
                filterContext.Result = new RedirectResult("/Home/AccessDenied");
            }
        }
    }
}
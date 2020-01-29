using SmartClass.Web.Models;
using System.Web;
using System.Web.Mvc;

namespace SmartClass.Web.Filters
{
    public class AuthOgrenci : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {

            var kullanici = (HttpContext.Current.Session["loginUser"] as UserModel);
            if (kullanici != null && kullanici.CurrentRoleId != 1)
            {
                filterContext.Result = new RedirectResult("/Home/AccessDenied");
            }
        }
    }
}
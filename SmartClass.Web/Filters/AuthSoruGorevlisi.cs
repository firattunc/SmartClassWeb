﻿using SmartClass.Web.Models;
using System.Web;
using System.Web.Mvc;

namespace SmartClass.Web.Filters
{
    public class AuthSoruGorevlisi : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if ((HttpContext.Current.Session["loginUser"] as UserModel).CurrentRoleId != 4)
            {
                filterContext.Result = new RedirectResult("/Home/AccessDenied");
            }
        }
    }
}
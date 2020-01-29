using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Entities.Dtos;
using Newtonsoft.Json;
using SmartClass.Web.Models;
using SmartClass.Web.ViewModels;

namespace SmartClass.Web.Controllers
{

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (TempData["loginValid"] == null)
                TempData["loginValid"] = "none";

            return View();
        }
        [HttpPost]
        public ActionResult LoginOl(UserModel model)
        {

            Session["loginUser"] = model;
            return Json(true,JsonRequestBehavior.AllowGet);
        }


        public ActionResult Register()
        {
            TempData["loginValid"] = "none";
            RegisterViewModel model = new RegisterViewModel();
            model.okulData = new SelectList("", "id", "okuladi");
            model.ilData = new SelectList("", "id", "ilAd");
            model.ilceData = new SelectList("", "id", "ilceAd");
            return View(model);
        }

        

        [HttpPost]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }

        public ActionResult AccessDenied()
        {
            return View();
        }
        public ActionResult HasError()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }

    }
}

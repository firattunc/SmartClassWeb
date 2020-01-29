using SmartClass.Web.Filters;
using SmartClass.Web.ViewModels;
using System.Web.Mvc;

namespace SmartClass.Web.Controllers
{
    [Auth]
    [Exc]
    [AuthAdmin]
    public class AdminController : Controller
    {   
        public ActionResult KullaniciEkle()
        {
            AdminKullaniciEkleModel model = new AdminKullaniciEkleModel();
            model.roleData = new SelectList("", "id", "roleAdi");
            model.ilData = new SelectList("", "id", "ilAdi");
            model.ilceData = new SelectList("", "id", "ilceAdi");
            return View(model);
        }

    }
}
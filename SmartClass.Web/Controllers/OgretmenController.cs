using SmartClass.Web.Filters;
using System.Web.Mvc;

namespace SmartClass.Web.Controllers
{
    [Exc]
    [Auth]
    [AuthOgretmen]
    public class OgretmenController : Controller
    {
        public ActionResult Listele()
        {
            return View();
        }
        // GET: Ogretmen
        public ActionResult OgrenciEkle()
        {
            return View();
        }
        public ActionResult Grafik()
        {
            return View();
        }
    }
}
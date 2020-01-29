using SmartClass.Web.Filters;
using System.Web.Mvc;

namespace SmartClass.Web.Controllers
{
    [Exc]
    [Auth]
    [AuthVeli]
    public class VeliController : Controller
    {
        public ActionResult Grafik()
        {
            return View();
        }
    }
}
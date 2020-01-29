using System.IO;
using System.Web;
using System.Web.Mvc;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using SmartClass.Web.Filters;
using SmartClass.Web.ViewModels;

namespace SmartClass.Web.Controllers
{
    [Exc]
    [Auth]
    [AuthSoruGorevlisi]
    public class SoruGorevlisiController : Controller
    {
        public ActionResult Sorular()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SoruEkle()
        {
            SoruKayitViewModel model = new SoruKayitViewModel();
            model.dersData = new SelectList("", "dersId", "dersAdi");
            model.konuData = new SelectList("", "konuId", "konuAdi");
            model.altBaslikData = new SelectList("", "altBaslikId", "altBaslikAdi");
            return View(model);
        }
        [HttpPost]
        public ActionResult SoruEkle(HttpPostedFileBase link)
        {
            string filePath = Path.Combine(Server.MapPath("~/Content/img/"), link.FileName);
            link.SaveAs(filePath);
            Account acc = new Account("manisa", "245921286863611", "_FcHPK_mYQCOLUVg7E4MKVeAsd8");
            Cloudinary cloudinary = new Cloudinary(acc);
            var uploadParamas = new ImageUploadParams()
            {
                File = new FileDescription(@"C:\Users\konto\Desktop\Kod Dökümanları\SmartClass-developer\SmartClass.Web\Content\img/" + link.FileName)
            };
            var uploadResult = cloudinary.Upload(uploadParamas);
            var linkUri = uploadResult.Uri;
            return Json(linkUri, JsonRequestBehavior.AllowGet);
        }

    }
}
using SmartClass.Web.Filters;
using SmartClass.Web.Models;
using SmartClass.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SmartClass.Web.Controllers
{
    [Auth]
    [AuthOgrenci]
    [Exc]
    public class OgrenciController : Controller
    {

        [TestStartFilter]
        public ActionResult TestStart()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TesteBasla(TestModel model)
        {
            try
            {
                Session["soruSayisi"] = model.soruSayisi;
                Session["soruNo"] = model.soruNo;
                Session["sorularList"] = model.Sorular;
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }        
        }
        [TestFilter]
        public ActionResult Test()
        {
            return View();
        }
        [HttpPost]
        public JsonResult TestiBitir()
        {
            Session["sorularList"] = new List<Soru>();
            Session["soruNo"] = 0;
            Session["soruSayisi"] = 0;
            return Json(null, JsonRequestBehavior.AllowGet);
        }
        [AuthOgrenci]
        [Auth]
        public ActionResult Testler()
        {
            TestlerimPageViewModel model = new TestlerimPageViewModel();            
            model.testData = new SelectList("", "id", "tarih");            
            return View(model);
        }
        // GET: Test

        [AuthOgrenci]
        [Auth]
        public ActionResult Grafikler()
        {
            return View();
        }
        [AuthOgrenci]
        [Auth]
        public ActionResult PuanGrafik()
        {
            return View();
        }

       [HttpPost]
        public JsonResult GetSoru(int id)
        {
            var sorularList = Session["sorularList"] as List<Soru>;
            if (sorularList.Count == 0)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
            Soru soru;
            var soruNo = Convert.ToInt32(Session["soruNo"]);
            var soruSayisi = Convert.ToInt32(Session["soruSayisi"]);
            if (soruNo + 1 != soruSayisi)
            {

                //Sayfa yenileniyormu
                if (id != 1)
                {
                    soruNo++;
                    Session["soruNo"] = soruNo;
                }
                soru = sorularList[soruNo];
            }
            else
            {
                var sayi = soruSayisi;
                TestiBitir();
                return Json(sayi + 1, JsonRequestBehavior.AllowGet);
            }

            return Json(soru.ImgUrl, JsonRequestBehavior.AllowGet);
        }

        // GET: SoruNo
        public JsonResult GetSoruNo()
        {
            try
            {
                var soruNo = Convert.ToInt32(Session["soruNo"]);
                return Json(soruNo + 1, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                return Json(null, JsonRequestBehavior.AllowGet);
            }

        }
        // GET: SoruId
        [HttpPost]
        public JsonResult GetSoruId()
        {
            try
            {
                var soruNo = Convert.ToInt32(Session["soruNo"]);
                var sorularList = Session["sorularList"] as List<Soru>;
                if (sorularList.Count == 0)
                {
                    return Json(null, JsonRequestBehavior.AllowGet);
                }
                return Json(sorularList[soruNo].Id, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                return Json(null, JsonRequestBehavior.AllowGet);
            }

        }

        public JsonResult GetSoruSayisi()
        {
            try
            {
                var soruSayisi = Convert.ToInt32(Session["soruSayisi"]);
                return Json(soruSayisi, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }
    }
}
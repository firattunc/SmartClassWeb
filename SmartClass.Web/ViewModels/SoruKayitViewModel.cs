using System.Web;
using System.Web.Mvc;

namespace SmartClass.Web.ViewModels
{
    public class SoruKayitViewModel
    {
        public string Cevap { get; set; }
        public HttpPostedFileBase link { get; set; }
        public int selectedDersId { get; set; }
        public int selectedKonuId { get; set; }
        public int selectedAltBaslikId { get; set; }

        public SelectList dersData { get; set; }

        public SelectList konuData { get; set; }

        public SelectList altBaslikData { get; set; }
    }
}
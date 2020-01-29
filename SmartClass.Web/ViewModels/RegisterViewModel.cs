using System.Web.Mvc;

namespace SmartClass.Web.ViewModels
{
    public class RegisterViewModel
    {
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int no { get; set; }

        public int selectedIlId { get; set; }
        public int selectedOkulId { get; set; }
        public int selectedIlceId { get; set; }

        public SelectList okulData { get; set; }

        public SelectList ilData { get; set; }

        public SelectList ilceData { get; set; }

        public bool isSuccess { get; set; }
    }
}
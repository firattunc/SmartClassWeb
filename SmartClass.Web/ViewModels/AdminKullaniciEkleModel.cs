using System.Web.Mvc;

namespace SmartClass.Web.ViewModels
{
    public class AdminKullaniciEkleModel
    {
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int selectedIlId { get; set; }
        public int selectedIlceId { get; set; }
        public int selectedRoleId { get; set; }
        public SelectList ilData { get; set; }

        public SelectList ilceData { get; set; }

        public SelectList roleData { get; set; }

    }
}
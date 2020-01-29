namespace SmartClass.Web.Models
{
    public class Soru
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string Cevap { get; set; }
        public int DersId { get; set; }
        public int AltBaslikId { get; set; }
        public int KonuId { get; set; }
    }
}
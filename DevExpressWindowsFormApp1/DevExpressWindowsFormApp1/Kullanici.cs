using System;

namespace DevExpressWindowsFormApp1
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string EPosta { get; set; }
        public string Sifre { get; set; } // Şifreyi de kaydetmek için ekledik
        public DateTime DogumTarihi { get; set; }
    }
}

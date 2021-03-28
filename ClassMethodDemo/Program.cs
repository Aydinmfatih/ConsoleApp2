using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = "25730598765";
            musteri1.AdıSoyadı = "Fatih Aydın";
            musteri1.MusteriMeslegi = "Yazılm mühendisi";
            musteri1.MusteriYasi = 20;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = "5123598765";
            musteri2.AdıSoyadı = "mustafa Aydın";
            musteri2.MusteriMeslegi = "Bilgisayar mühendisi";
            musteri2.MusteriYasi = 20;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = "865598765";
            musteri3.AdıSoyadı = "talha aydın";
            musteri3.MusteriMeslegi = "Seller runing suport";
            musteri3.MusteriYasi = 20;

            Musteri musteri4 = new Musteri();
            musteri4.MusteriId = "12367851782";
            musteri4.AdıSoyadı = "Selman jir can";
            musteri4.MusteriMeslegi = "Yazılm mühendisi";
            musteri4.MusteriYasi = 22;


            Musteri[] musteri = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Cikarma(musteri4);
            musteriManager.Ekleme(musteri3);
            musteriManager.Liste(musteri);
            
            
            
            
            

           
            

        }
    }
}

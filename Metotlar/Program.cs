using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Product urun1 = new Product();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Product[] urunler = new Product[] {urun1,urun2 };
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi + " : " + urun.Fiyati+ " : " +urun.Aciklama);
            }
            Console.WriteLine("-----------Metodlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun1);
            sepetManager.Ekle2("armut", "Yeşil armut", 12);
            sepetManager.Ekle2("elma", "Yeşil elma", 12);
            sepetManager.Ekle2("karpuz", "Yeşil karpuz", 12);
        }
    }
}

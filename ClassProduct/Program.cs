using System;

namespace ClassProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            product urun1 = new product();
            urun1.urunAdi = "mavi thsirt";
            urun1.urunSize = "medium";
            urun1.urunFiyat = 20;

            product  urun2 = new product();
            urun2.urunAdi = "yeşil thsirt";
            urun2.urunSize = "large";
            urun2.urunFiyat = 15;

            product urun3 = new product();
            urun3.urunAdi = "mavi thsirt";
            urun3.urunSize = "medium";
            urun3.urunFiyat = 36;

            product[] urunler = new product[] { urun1, urun2, urun3 };

            //Foreach döngüsü ile

            /*foreach (var urun in urunler) 
            {
                Console.WriteLine(urun.urunAdi + " " +urun.urunSize  + " "+urun.urunFiyat );
            }*/
            // for döngüsü ile

            /*
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAdi + " " + urunler[i].urunFiyat + " "+urunler[i].urunSize);
            }*/
            int s = 0;
            while ( s < urunler.Length )
            {
                Console.WriteLine(urunler[s].urunFiyat);

                s++;
            }

        }
        class product
        {
            public string urunAdi { get; set; }
            public string urunSize { get; set; }
            public int urunFiyat { get; set; }
        }
    }
}

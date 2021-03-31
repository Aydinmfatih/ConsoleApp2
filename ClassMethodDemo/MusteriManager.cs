using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri eklenmiştir : " + musteri.AdıSoyadı + " : " + musteri.MusteriMeslegi);

        }

        public  void Cikarma(Musteri musteri)
        {
            Console.WriteLine("Müşteri çıkartılmıştır : " +musteri.AdıSoyadı + " "+musteri.MusteriMeslegi);

        }



        public  void Liste(Musteri[] musteri )
        {
            foreach(var musteriler in musteri)
            {
                Console.WriteLine(musteriler.AdıSoyadı + " " + musteriler.MusteriMeslegi + " " + musteriler.MusteriYasi);
            }
        }
    }
}
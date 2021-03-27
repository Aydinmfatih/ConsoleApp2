using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Engin demiroğ";
            kurs1.KursAdi = "c + +";
            kurs1.İzlenmeOrani = 35;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Kerem";
            kurs2.KursAdi = "Java";
            kurs2.İzlenmeOrani = 56;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "berkay";
            kurs3.KursAdi = "pyhton";
            kurs3.İzlenmeOrani = 80;

            // Console.WriteLine(kurs2.KursAdi +" : "+ kurs2.Egitmen);


             Kurs[] kurslar = new Kurs[] { kurs1 , kurs2, kurs3 };
            /*foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen + " : " +kurs.KursAdi + " : " + kurs.İzlenmeOrani  );
            }*/
            for (int i = 0; i < kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i].Egitmen + " : " +kurslar[i].İzlenmeOrani);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
         
    }
}

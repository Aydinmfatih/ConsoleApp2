using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            //lenght = eleman sayısı
            string[] kurslar = new string[] {"Pyhton","Yazılım geliştirici kursu","Java kursu","Programlamaya giriş"};

            for (int i = 0; i <kurslar.Length; i++)

            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu");
        }

        
        
    }
}

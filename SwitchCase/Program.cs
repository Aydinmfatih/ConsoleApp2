using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Bir sayi giriniz");
            sayi = Convert.ToInt16(Console.ReadLine());
            switch (sayi)
            {
                case 1:
                    Console.WriteLine("pazartesi");
                    break;

                case 2: Console.WriteLine("salı");
                    break;

                case 3:
                    Console.WriteLine("çarşamba");
                    break;
                case 4:
                    Console.WriteLine("perşembe");
                    break;
                case 5:
                    Console.WriteLine("cuma");
                    break;

                default: Console.WriteLine("hatalı gün girişi");
                    break;
            }
        }
    }
}

using System;

namespace MethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string blg;
            Console.WriteLine("metni giriniz :");
            blg = Console.ReadLine();
            Yazdir(blg);
            Console.Read();

        }

        public static void Yazdir(string mesaj)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(mesaj);
            }

        }
    }

}

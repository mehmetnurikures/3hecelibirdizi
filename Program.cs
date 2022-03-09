using System;
namespace _3hecelibirdizi
{
    class Program
    {
        static void Main(string[] args)
        {
            //UcElemanliBirKüme();
            BesElemanliBirKume();
        }

        private static void BesElemanliBirKume()
        {
            int[] sayilar = new int[5];
            sayilar[0] = 2;
            sayilar[1] = 5;
            sayilar[2] = 8;
            sayilar[3] = 15;
            sayilar[4] = 67;

            Console.WriteLine();
            Console.WriteLine("\n 5 Rakamlı Dizideki Sayılar: ");
            Console.WriteLine();
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("\n{0,10}", sayilar[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void UcElemanliBirKüme()
        {
            int[] numaralar = new int[3];
            numaralar[0] = 3;
            numaralar[1] = 5;
            numaralar[2] = 7;
            for (int i = 0; i < numaralar.Length; i++)
            {
                Console.WriteLine(numaralar[i]);
            }
            Console.ReadKey();
        }
    }
}

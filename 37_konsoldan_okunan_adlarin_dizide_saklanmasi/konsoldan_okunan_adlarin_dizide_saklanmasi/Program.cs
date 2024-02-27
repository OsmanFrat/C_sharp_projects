using System;

namespace konsoldan_okunan_adlarin_dizide_saklanmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("dizinin eleman sayısı: ");
            n = Convert.ToInt32(Console.ReadLine());

            string[] adlar = new string[n];

            for (int i = 0; i <= adlar.Length-1; i++)
            {
                Console.WriteLine(i + ". eleman: ");
                adlar[i] = Console.ReadLine();
            }

            for (int j = 0; j <= adlar.Length -1; j++)
            {
                Console.WriteLine("dizinin " + j + ". elemanı: " + adlar[j]);
            }

            Console.ReadLine();
        }
    }
}

using System;

namespace n_adet_sayinin_ortalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, top = 0, ort;

            Console.Write("n değeri: "); n = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[n];

            for(int i = 0; i <= sayilar.Length-1; i++)
            {
                Console.Write(i + " indeksli elemanı gir: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i <= sayilar.Length-1; i++)
            {
                top = top + sayilar[i];
            }

            ort = top / n;
            Console.WriteLine("ortalama = " + ort);

            Console.ReadLine();
        }
    }
}

using System;

namespace birden_n_e_kadar_olan_çift_sayi_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.Write("n değeri: ");
            n = Convert.ToInt32(Console.ReadLine());

            yazCiftSayi(n);

            Console.ReadLine();
        }

        static void yazCiftSayi(int n)
        {
            for (int i = 2; i <= n; i = i + 2)
                Console.WriteLine(i);
        }
    }
}

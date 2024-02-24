using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_adet_sayinin_ortalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, toplam, sayac, sayi;
            n = toplam = sayac = 0;

            Console.WriteLine("n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (sayac = 1; sayac <= n; sayac++)
            {
                Console.WriteLine(sayac + ". sayı: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            }

            Console.WriteLine("Ortalama: " + toplam / n);

            Console.ReadLine();
        }
    }
}

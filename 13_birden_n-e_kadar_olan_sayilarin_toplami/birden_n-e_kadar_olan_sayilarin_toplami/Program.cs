using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birden_n_e_kadar_olan_sayilarin_toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, toplam, sayac;
            n = toplam = sayac = 0;

            Console.WriteLine("n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(sayac = 1; sayac <= n; sayac++)
            {
                toplam += sayac;
            }
            Console.WriteLine(n + " kadar ki sayıların toplamı: " + toplam);

            Console.ReadLine();
        }
    }
}

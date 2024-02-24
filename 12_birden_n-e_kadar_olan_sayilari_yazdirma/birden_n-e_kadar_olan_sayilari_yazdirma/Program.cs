using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birden_n_e_kadar_olan_sayilari_yazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sayac = 0;

            Console.WriteLine("n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(sayac = 1; sayac <= n; sayac++)
            {
                Console.WriteLine(sayac);
            }

            /* while döngüsü ile:
             * sayac = 1;
             * while(sayac <= n)
             * {
             *     Console.WriteLine(sayac);
             *     sayac++;
             * }
            */

            Console.Read();
        }
    }
}

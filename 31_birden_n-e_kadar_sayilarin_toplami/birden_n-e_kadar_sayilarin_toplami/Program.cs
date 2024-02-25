using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birden_n_e_kadar_sayilarin_toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("n değeri: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("n: " + n + " toplam: " + ntopla(n));
            Console.Read();
        }

        static int ntopla(int x)
        {
            int toplam = 0;
            for(int i = 1; i <= x; i++)
            {
                toplam = toplam + i;
            }

            return toplam;
        }
    }
}

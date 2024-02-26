using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birden_n_e_kadar_sayilarin_faktoriy_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n değeri: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("n = " + i + " n! = " + fk(i));
            }
            Console.Read();
        }
        static int fk(int x)
        {
            int f = 1;
            for (int i = 1; i <= x; i++)
                f = f * i;
            return f;
        }
    }
}

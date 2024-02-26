using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_faktoriyel_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("n değeri: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("n = " + n + " n!= " + fk(n));

            Console.ReadLine();
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

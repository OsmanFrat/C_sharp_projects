using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tek_bilinmeyenli_denklem
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;

            Console.WriteLine("a değenini giriniz: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("b değenini giriniz: ");
            b = Convert.ToDouble(Console.ReadLine());

            x = -b / a;

            Console.Write("x = " + x);

            Console.ReadLine();
        }
    }
}

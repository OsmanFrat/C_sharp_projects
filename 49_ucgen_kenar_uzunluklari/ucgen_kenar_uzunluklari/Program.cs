using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucgen_kenar_uzunluklari
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, hipo, h, aci;

            Console.Write("a açısı: ");
            aci = Convert.ToDouble(Console.ReadLine());

            Console.Write("a uzunluğu: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b uzunluğu: ");
            b = Convert.ToDouble(Console.ReadLine());

            hipo = Math.Sqrt(a * a * b * b);
            h = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(aci * Math.PI / 180));

            Console.Write("Hipotenüs = " + hipo + " h = " + h);

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucgenin_alani
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h, alan1, alan2, aci;

            Console.Write("a açısı: ");
            aci = Convert.ToDouble(Console.ReadLine());

            Console.Write("a uzunluğu: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b uzunluğu: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("h uzunluğu: ");
            h = Convert.ToDouble(Console.ReadLine());

            alan1 = a * h / 2;
            alan2 = a * b * Math.Sin(aci * Math.PI / 180) / 2;

            Console.WriteLine("Alan1 = " + alan1 + " Alan2 = " + alan2);

            Console.ReadLine();
        }
    }
}

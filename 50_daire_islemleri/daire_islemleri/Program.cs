using System;

namespace daire_islemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, a, dilimalan, alan;
            const double pi = Math.PI;

            Console.Write("r değeri: ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.Write("a değeri: ");
            a = Convert.ToDouble(Console.ReadLine());

            alan = pi * r * r;
            dilimalan = pi * r * r * a / 360;

            Console.WriteLine("Alan = " + alan + " Dilimalan = " + dilimalan);

            Console.ReadLine();
        }
    }
}

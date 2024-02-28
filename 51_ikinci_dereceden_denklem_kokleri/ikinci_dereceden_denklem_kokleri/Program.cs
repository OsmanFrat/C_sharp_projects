using System;

namespace ikinci_dereceden_denklem_kokleri
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, d;

            Console.Write("a değeri: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b değeri: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c değeri: ");
            c = Convert.ToDouble(Console.ReadLine());

            //diskriminantı hesapla
            d = b * b - 4 * a * c;

            if (d < 0)
            {
                Console.Write("Sanal kök var");
            }    
            else if (d == 0)
            {
                x1 = -b / 2 * a;
                Console.Write("Tek kök var: " + x1);
            }
            else
            {
                x1 = -b - Math.Sqrt(d) / 2 * a;
                x2 = -b + Math.Sqrt(d) / 2 * a;
                Console.Write("Çift kök var. x1 = " + x1 + " x2 = " + x2);
            }

            Console.ReadLine();

        }
    }
}

using System;

namespace topla_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1 = 2.866, sayi2 = 5.795, toplam = 0;

            toplam = topla(sayi1, sayi2);

            Console.WriteLine("Toplam: " + toplam);
            
            Console.ReadLine();
        }

        static double topla(double x, double y)
        {
            double top = x + y;
            return top;
        }
    }
}

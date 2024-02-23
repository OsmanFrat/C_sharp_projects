using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inch_to_cm
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch, cm;
            const double oran = 2.54;

            Console.Write("Inch değerini giriniz: ");
            inch = Convert.ToDouble(Console.ReadLine());
                
            cm = oran * inch;

            Console.WriteLine(inch + " inç değeriniz " + cm + " cm'dir.");

            Console.ReadLine();
        }
    }
}

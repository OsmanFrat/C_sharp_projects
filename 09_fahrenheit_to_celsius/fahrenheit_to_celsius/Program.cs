using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrenheit_to_celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.WriteLine("Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            celsius = (fahrenheit - 32) / 1.8;

            Console.WriteLine("Fahrenhayt: " + fahrenheit + " Celsius " + celsius);

            Console.ReadLine();
        }
    }
}

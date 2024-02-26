using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_sinifi_ile_matematiksel_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.Write("x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("y: ");
            y = Convert.ToDouble(Console.ReadLine());

            //metotlar
            Console.WriteLine("x\'in karesi: " + Math.Pow(x,2));
            Console.WriteLine("x\'in küpü: " + Math.Pow(x, 2));
            Console.WriteLine("x\'in karekökü: " + Math.Sqrt(x));
            Console.WriteLine("x\'in mutlak değeri: " + Math.Abs(x));
            Console.WriteLine("küçük olan: " + Math.Min(x,y));
            Console.WriteLine("büyük olan: " + Math.Max(x,y));
            Console.WriteLine("x\'i küçük tam sayıya yuvarla: " + Math.Floor(x));
            Console.WriteLine("x\'i büyük tam sayıya yuvarla: " + Math.Ceiling(x));
            Console.WriteLine("x\'i tam sayıya yuvarla: " + Math.Round(x));
            Console.WriteLine("Log10(x): " + Math.Log10(x));
            Console.WriteLine("Sin(x): " + Math.Sin(x));
            Console.WriteLine("Cos(x): " + Math.Cos(x));

            Console.ReadLine();
        }
    }
}

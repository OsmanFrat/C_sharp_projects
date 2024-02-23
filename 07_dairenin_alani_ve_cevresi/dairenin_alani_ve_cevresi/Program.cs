using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dairenin_alani_ve_cevresi
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, alan, cevre;
            const double pi = 3.14;

            Console.WriteLine("Yarıçapı giriniz: ");
            r = Convert.ToDouble(Console.ReadLine());

            alan = pi * (r * r);
            cevre = (pi * 2) * r;

            Console.WriteLine("Alan: " + alan + "\nÇevre: " + cevre);

            Console.ReadLine();
        }
    }
}

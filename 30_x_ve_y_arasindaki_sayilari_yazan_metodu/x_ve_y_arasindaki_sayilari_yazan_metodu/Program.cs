using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_ve_y_arasindaki_sayilari_yazan_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("x değeri: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y değeri: ");
            y = Convert.ToInt32(Console.ReadLine());

            xyyaz(x, y);
            Console.ReadLine();

        }
        static void xyyaz(int x, int y)
        {
            if (x <= y)
            {
                for (; x <= y; x++)
                    Console.WriteLine(x);
            }
            else
            {
                for (; y <= x; y++)
                    Console.WriteLine(y);
            }
        }
    }
}

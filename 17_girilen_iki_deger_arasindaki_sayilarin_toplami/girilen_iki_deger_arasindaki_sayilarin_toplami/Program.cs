using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilen_iki_deger_arasindaki_sayilarin_toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, top = 0;

            Console.WriteLine("x değerini giriniz: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y değerini giriniz: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x <= y)
            {
                for (; x <= y; x++)
                    top += x;
            }
            else
                for (; y <= x; y++)
                    top += y;
            Console.WriteLine("Toplam: " + top);

            Console.ReadLine();
        }
    }
}

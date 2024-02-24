using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilen_iki_sayi_arasindaki_sayilari_yaz
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("x değerini giriniz: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y değerini giriniz: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x <= y)
            {
                for (; x <= y; x++)
                    Console.WriteLine(x);
            }
            else
                for (; y <= x; y++)
                    Console.WriteLine(y);
            
            
            Console.ReadLine();
        }
    }
}

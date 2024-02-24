using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baglantisiz_ic_ice_for_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            for(b = 1; b <= 5; b++)
            {
                /* Üstteki döngü bir kez çalıştığında, bu döngü 5 defa, yani bitene kadar çalışır
                *  ve tekrar üstteki döngüye dönülür. Ardından üstteki döngüde b değeri 2 olur ve tekrar
                *  altaki döngüye dönülür. Aynı işlem b değeri 5'i geçinceye kadar devam eder.*/  
                for (a = 1; a <= 5; a++)
                {
                    Console.WriteLine("b = " + b + "\t a = " + a); 
                }
                Console.WriteLine("---------------");
            }

            Console.ReadLine();
        }
    }
}

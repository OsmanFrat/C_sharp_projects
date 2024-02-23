using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ad_yazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad;

            Console.WriteLine("Adınızı yazınız: ");
            
            ad = Console.ReadLine();
            
            Console.Write("merhaba " + ad);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametreli_merhaba_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("n: ");
            n = Convert.ToInt32(Console.ReadLine());

            yaz(n);

            Console.Read();
        }

        static void yaz(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Merhaba");
            }
        }
    }
}

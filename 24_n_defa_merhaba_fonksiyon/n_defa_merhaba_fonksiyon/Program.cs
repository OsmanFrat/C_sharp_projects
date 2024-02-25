using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_defa_merhaba_fonksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.WriteLine("n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                yaz();
            }

            Console.Read();
        }

        static void yaz()
        {
            Console.WriteLine("Merhaba");
        }
    }
}

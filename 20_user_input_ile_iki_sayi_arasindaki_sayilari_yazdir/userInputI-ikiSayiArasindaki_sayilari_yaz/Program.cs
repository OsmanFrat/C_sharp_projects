using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int baslangic, bitis, artis = 1;

            Console.WriteLine("Baslangıç: ");
            baslangic = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitiş: ");
            bitis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Artiş: ");
            artis = Convert.ToInt32(Console.ReadLine());

            // ; ile başlamasının sebebi doğrudan döngünün başlangıç değerinden başlatmak istediğimiz için.
            for (; baslangic <= bitis; baslangic += artis)
            {
                Console.WriteLine(baslangic);
            }

            Console.ReadLine();
        }
    }
}

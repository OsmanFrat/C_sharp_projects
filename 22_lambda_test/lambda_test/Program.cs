using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            //.Count() fonksiyonu içine yazılan şartlara göre o şarta uyan elemanların sayısını yazdırır.
            int ciftsayi = sayilar.Count(x => x % 2 == 0);
            
            Console.WriteLine("Çift sayı adedi: " + ciftsayi);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilen_iki_sayinin_toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam = 0;

            Console.WriteLine("Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam: " + toplam);

            Console.ReadLine();
        }
    }
}

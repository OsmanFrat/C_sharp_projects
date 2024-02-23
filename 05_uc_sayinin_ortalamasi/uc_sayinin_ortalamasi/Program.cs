using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc_sayinin_ortalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sayi3, ortalama = 0;

            Console.WriteLine("Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Üçüncü sayıyı giriniz: ");
            sayi3 = Convert.ToInt32(Console.ReadLine());

            ortalama = (sayi1 + sayi2 + sayi3) / 3;

            Console.WriteLine("Girdiğiniz sayıların ortalaması: " + ortalama);

            Console.ReadLine();
        }
    }
}

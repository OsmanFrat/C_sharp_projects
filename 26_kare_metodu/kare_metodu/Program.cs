using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kare_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;

            Console.WriteLine("Karesini almak istediğiniz sayıyı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sayı: " + sayi + " Karesi: " + kare(sayi));

            Console.ReadLine();
        }

        static int kare(int n)
        {
            int k = n * n;
            return k;
        }
    }
}

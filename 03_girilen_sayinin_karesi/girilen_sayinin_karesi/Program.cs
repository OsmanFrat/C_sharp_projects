using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilen_sayinin_karesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, kare;

            Console.WriteLine("Karesini istediğiniz sayıyı giriniz: ");

            sayi = Convert.ToInt32(Console.ReadLine());

            kare = sayi * sayi;

            Console.WriteLine("Girdiğiniz sayının karesi: " + kare);

            Console.Read();
        }
    }
}

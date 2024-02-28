using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_kadar_input_ve_en_buyuk_sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, enbuyuk = 0, sayac = 0, n;

            Console.Write("n değeri: ");
            n = Convert.ToInt32(Console.ReadLine());

            while(sayac < n)
            {
                Console.Write("sayı giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if(sayi > enbuyuk)
                {
                    enbuyuk = sayi;   
                }
                sayac++;
            }
            
            Console.WriteLine("en büyük sayı: " + enbuyuk);

            Console.ReadLine();
        }
    }
}

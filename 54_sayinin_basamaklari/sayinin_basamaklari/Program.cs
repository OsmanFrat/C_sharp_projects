using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayinin_basamaklari
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, s = 1;

            Console.Write("sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            // sayı 10'dan büyük olduğu sürece 10'a bölerek
            // s'i yani sayacı bir arttırıyoruz ve böylece
            // çıkan s değişkeni bize basamak sayısını vericek
            
            while (sayi > 10)
            {
                sayi /= 10;
                s++;
            }

            Console.WriteLine("sayının basamak sayısı = " + s);

            Console.ReadLine();
        }
    }
}

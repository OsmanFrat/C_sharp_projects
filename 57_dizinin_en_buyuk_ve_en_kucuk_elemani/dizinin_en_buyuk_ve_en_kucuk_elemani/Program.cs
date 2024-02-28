using System;

namespace dizinin_en_buyuk_ve_en_kucuk_elemani
{
    class Program
    {
        static void Main(string[] args)
        {
            int en_buyuk = 0;
            int en_kucuk = 10000000;
            int[] dizi = { 1, 9, 2, 7, 3, 6, 4, 5 };

            for (int i = 0; i < dizi.Length - 1; i++)
            {
                if (dizi[i] > en_buyuk)
                {
                    en_buyuk = dizi[i];
                }
                if (dizi[i] < en_kucuk)
                {
                    en_kucuk = dizi[i];
                }
                    
            }

            Console.WriteLine("Dizideki en büyük sayı = " + en_buyuk
                + " ve en küçük sayı = " + en_kucuk);

            Console.ReadLine();
        }
    }
}

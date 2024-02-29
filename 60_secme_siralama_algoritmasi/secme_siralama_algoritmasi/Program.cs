using System;

namespace secme_siralama_algoritmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //elemanların yerini değiştirmek için değerleri geçici olarak atanacak değişken
            int yardimci;
            //dizi
            int[] dizi = { 5, 1, 4, 2, 8 };

            for (int i = 0; i < dizi.Length-1; i++)
            {
                for (int  j= i + 1; j < dizi.Length; j++)
                {
                    if (dizi[i] > dizi[j])
                    {
                         yardimci = dizi[j]; //dizi[j]'deki elemanın değerini geçici olarak ata
                         dizi[j] = dizi[i]; //dizi[j]'nin değerini dizi[i] yap
                         dizi[i] = yardimci; //dizi[i]'ye önceden saklanan dizi[j]'nin geçici olarak
                                             //saklanan değerini ata
                    }
                   
                }
            }

            foreach (int eleman in dizi)
            {
                Console.WriteLine(eleman);
            }

            Console.ReadLine();
        }
    }
}

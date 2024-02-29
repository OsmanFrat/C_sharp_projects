using System;

namespace iki_boyutlu_dizilerde_matematiksel_islemler
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 satır 3 sütunlu 3 dizi oluştur
            int[,] dizi1 = new int[2, 3];
            int[,] dizi2 = new int[2, 3];
            int[,] dizi3 = new int[2, 3];

            //dizi1 değerlerini konsoldan oku
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("eleman i = " + i + " j = " + j + ":");
                    dizi1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //dizi2 değerlerini konsoldan okuyalım
            for (int k = 0; k < 2; k++)
            {
                for (int l = 0; l < 3; l++)
                {
                    Console.Write("eleman k = " + k + " l = " + l + ":");
                    dizi2[k, l] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //dizi3'ün elemanları dizi1 ve dizi2'nin elamanlarının toplamıdır
            for (int m = 0; m < 2; m++)
            {
                for (int n = 0; n < 3; n++)
                {
                    dizi3[m, n] = dizi1[m, n] + dizi2[m, n];
                }
            }
            Console.WriteLine(""); //boş satır

            //dizi3 elemanlarını yazdır
            Console.WriteLine("işlem sonucu:");
            for (int m = 0; m < 2; m++)
            {
                if (m % 1 == 0) Console.Write("\n");
                for (int n = 0; n < 3; n++)
                {
                    Console.Write("d" + m + n + ":" + dizi3[m,n] + "\t");
                }
            }

            Console.ReadLine();

        }
    }
}

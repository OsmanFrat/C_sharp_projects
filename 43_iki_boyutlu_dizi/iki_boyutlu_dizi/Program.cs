using System;

namespace iki_boyutlu_dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 satır 3 sütun bir dizi oluştur
            int[,] dizi = new int[2, 3];

            // konsoldan dizi değerlerini oku
            for (int i = 0; i < 2; i++)// satırlar
            {
                for (int j = 0; j < 3; j++)// sütunlar
                {
                    Console.Write("satır = " + i + " eleman = " + j + ":");
                    dizi[i, j] = Convert.ToInt32(Console.ReadLine()); 
                }
            }

            //dizi elemanlarını yaz
            for (int i = 0; i < 2; i++)
            {
                if (i % 1 == 0) Console.Write("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("eleman" + i + j + ":" + dizi[i,j] + "\t");
                }
                
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace girilen_kelimenin_tersten_yazilmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime = "";
            int s;

            Console.Write("kelime: ");
            kelime = Console.ReadLine();

            //dizi indeksi alınır
            s = kelime.Length - 1;

            while (s >= 0)
            {
                Console.Write(kelime[s]);
                s--;
            }

            Console.ReadLine();
        }
    }
}

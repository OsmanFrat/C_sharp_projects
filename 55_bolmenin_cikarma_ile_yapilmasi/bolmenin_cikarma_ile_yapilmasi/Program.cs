using System;

namespace bolmenin_cikarma_ile_yapilmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int bolen, bolunen, s = 0;

            Console.Write("bölünen sayı: ");
            bolunen = Convert.ToInt32(Console.ReadLine());

            Console.Write("bölen sayı: ");
            bolen = Convert.ToInt32(Console.ReadLine());

            while(bolunen >= bolen)
            {
                bolunen -= bolen;
                s++;
            }
            Console.Write("Sonuç: " + s);

            Console.ReadLine();

        }
    }
}

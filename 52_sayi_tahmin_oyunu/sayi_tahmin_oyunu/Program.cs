using System;

namespace sayi_tahmin_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, rs;

            Random ras = new Random();
            rs = ras.Next(1, 10);

            do
            {
                Console.Write("sayı giriniz: ");
                s = Convert.ToInt32(Console.ReadLine());
                if (s > rs) Console.WriteLine("daha küçük sayı giriniz!: ");
                if (s < rs) Console.WriteLine("daha büyük sayı giriniz!: ");
            } while (s != rs);

            Console.Write("tebrikler! " + s + " doğru tahmin...");

            Console.ReadLine();
        }
    }
}

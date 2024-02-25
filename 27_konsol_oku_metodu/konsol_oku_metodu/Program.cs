using System;

namespace konsol_oku_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = Oku();

            Console.WriteLine("sayiniz: " + sayi);
            Console.ReadLine();
        }

        static int Oku()
        {
            Console.WriteLine("Sayı giriniz: ");
            int s = Convert.ToInt32(Console.ReadLine());
            return s;
        }
    }
}

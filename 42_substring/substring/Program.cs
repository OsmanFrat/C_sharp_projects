using System;

namespace substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("metin giriniz: ");
            string metin = Console.ReadLine();

            metin = metin.ToUpper();

            for (int i = 0; i <= metin.Length; i++)
            {
                Console.WriteLine(metin.Substring(0, i));
            }

            Console.ReadLine();
        }
    }
}

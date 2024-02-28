using System;

namespace dizilerde_matematiksel_islemler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c = new int[5];

            for (int i = 0; i < 5; i++)
            {
                c[i] = a[i] + b[i];
            }

            foreach (int eleman in c)
            {
                Console.WriteLine(eleman);
            }

            Console.ReadLine();


        }
    }
}

using System;

namespace nesne_tab_dairenin_alani
{
    class Program
    {
        class Daire
        {
            public double r;
            public double Alan(double r)
            {
                return Math.PI * r * r;
            }
        }
        static void Main(string[] args)
        {
            Daire d1 = new Daire();
            d1.r = 1;
            Console.WriteLine("alan = " + d1.Alan(d1.r));
            
            Console.ReadLine();
        }
        
    }
}

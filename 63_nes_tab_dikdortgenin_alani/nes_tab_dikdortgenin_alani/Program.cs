using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nes_tab_dikdortgenin_alani
{
    class Dikdortgen
    {
        public int uzunluk, genislik;
        public double alan()
        {
            return uzunluk * genislik;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dk1 = new Dikdortgen();

            Console.Write("Uzunluk: ");
            dk1.uzunluk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Genişlik: ");
            dk1.genislik = Convert.ToInt32(Console.ReadLine());

            Console.Write("d1 alan = " + dk1.alan());

            Console.ReadLine();
        }
    }
}

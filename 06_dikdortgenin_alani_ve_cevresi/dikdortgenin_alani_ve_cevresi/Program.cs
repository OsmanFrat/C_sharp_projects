using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dikdortgenin_alani_ve_cevresi
{
    class Program
    {
        static void Main(string[] args)
        {
            int uzun_kenar, kisa_kenar, alan, cevre = 0;

            Console.WriteLine("Uzun kenarı giriniz: ");
            uzun_kenar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kısa kenarı giriniz: ");
            kisa_kenar = Convert.ToInt32(Console.ReadLine());

            alan = uzun_kenar * kisa_kenar;
            cevre = (uzun_kenar * 2) + (kisa_kenar * 2);

            Console.WriteLine("Dikdörtgeninizin alanı: " + alan + "\nDikdörtgeninizin çevresi: " + cevre);

            Console.ReadLine();
        }
    }
}

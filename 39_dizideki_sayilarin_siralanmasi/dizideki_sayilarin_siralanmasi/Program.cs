using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizideki_sayilarin_siralanmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n değeri: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[n];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(i + " indeksli elemanı giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("--------------");

            Array.Sort(sayilar);
            foreach (int  eleman in sayilar)
            {
                Console.WriteLine(eleman);
            }

            Console.WriteLine("--------------");

            Array.Reverse(sayilar);
            foreach (int terseleman in sayilar)
            {
                Console.WriteLine(terseleman);
            }

            Console.ReadLine();
        }
    }
}

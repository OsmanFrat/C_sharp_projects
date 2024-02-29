using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizide_dogrusal_arama
{
    class Program
    {
        static void Main(string[] args)
        {
            bool durum = true;
            int s = 0, anahtar;
            int[] dizi = { 2, 3, 5, 7, 11, 13, 17 };

            Console.Write("Aranacak değeri giriniz: ");
            anahtar = Convert.ToInt32(Console.ReadLine());

            for (;  s < dizi.Length; s++)
            {
                if (dizi[s] == anahtar)
                {
                    durum = true;
                    break;
                }
                else
                    durum = false;
            }

            if (durum == true)
            {
                Console.Write("aranan değer " + s + ". indekste bulundu");
            }
            else
                Console.Write("aranan değer bulunamadı");

            Console.ReadLine();
            
        }
    }
}

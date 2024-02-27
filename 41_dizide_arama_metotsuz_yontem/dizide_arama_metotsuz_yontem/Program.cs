using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizide_arama_metotsuz_yontem
{
    class Program
    {
        static void Main(string[] args)
        {
            string anahtar; 
            string sonuc = "bulunamadı"; 
            int indeks = 0;
            string[] isimler = new string[5];

            isimler[0] = "ali";
            isimler[1] = "veli";
            isimler[2] = "ahmet";
            isimler.SetValue("mehmet", 3);
            isimler.SetValue("osman", 4);

            // dizi elemanlarını A'dan Z'ye sırala
            Array.Sort(isimler);

            // Aranacak anahtar kelimeyi kullanıcıdan al
            Console.Write("anahtar kelime: ");
            anahtar = Console.ReadLine();
            anahtar = anahtar.Trim(); // Varsa boşlukları sil

            // anahtar kelimeyi ara, bulunursa indeksini değişkene ata
            do
            {
                if(isimler[indeks] == anahtar)
                {
                    sonuc = indeks + ". indekste!";
                    break;
                }

                indeks++;

            } while (indeks < isimler.Length);
            
            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }
}

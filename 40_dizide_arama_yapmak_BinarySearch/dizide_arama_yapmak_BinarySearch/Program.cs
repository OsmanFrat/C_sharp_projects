using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizide_arama_yapmak_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string anahtar; int indeks = 0;
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

            // anahtar ekimeyi arar ve kelime bulursa indeksini değişkene ata
            indeks = Array.BinarySearch(isimler, anahtar);

            // anahtar kelime bulunursa BinarySearch() elemanın indeksini döndür
            // bulunmadıysa -1 döner
            if (indeks <= -1) Console.Write("aranan kelime bulunamadı");
            else Console.Write("aranan metin dizinin " + (indeks +1) + ". elemanıdır");

            Console.ReadLine();

        }
    }
}

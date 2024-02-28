using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asal_sayi_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sonuc = true; //kontrol değişkeni. sayı en başta asal sayılıyor
            
            Console.Write("Sayı: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            /* konsoldan okunan sayı 2'den başlanarak kendisinden 1 küçük sayıya kadar mod işlemine tabi 
             * tutulut. Eğer mod=0 olursa bu sayı başka bir sayıya bölünüyor demektir ve sonuç=false
             olur. yani sayı asal değildir. Aksi taktirde asaldır.*/
            for (int i = 2; i <= sayi-1; i++)
            {
                if(sayi % i==0)
                {
                    sonuc = false;
                    break;
                }
            }

            if(sonuc == true)
            {
                Console.WriteLine(sayi + " asaldır.");
            }
            else
            {
                Console.WriteLine(sayi + " asal değildir.");
            }

            Console.ReadLine();
        }
    }
}

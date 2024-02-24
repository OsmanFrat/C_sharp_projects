using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baglantili_ic_ice_for_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++) 
            {
                /* İlk döngü bir defa çalışır ve alta inilir.
                 * İkinci döngü j değeri i değerine ulaşıncaya kadar çalışır. 
                 * j değeri i'yi geçince döngü biter ve üstteki döngüye geçilir.
                 * i değeri artık 2 'dir ve tekrar çalışır.
                 * İkinci döngüdeki j değeri tekrar 1 olmuştur. Çünkü içteki 
                 * döngü her tamamlandığında sıfırlanır.
                 * Bu sefer i değeri 2 oluğu için ekranda ikinci satıra 12 yazar ve
                 * tekrar döngü tamamlandığı için sıfırlanır ve üstteki döngüye dönülür.
                 * Bu işlemler üstteki döngüdeki i değeri 10'u geçinceye kadar tekrarlanır.*/

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);// .Write() metodunu kullanmamızın sebebi, sayıları yan yana yazmak istememiz.
                }
                Console.WriteLine("");// Her döngüler tamamlandığında yeni satıra geçmek için kullanılır.
            }

            Console.ReadLine();
        }
    }
}

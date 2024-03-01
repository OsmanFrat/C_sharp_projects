using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne_kopyalama_ve_kopyalanan_nesneye_etkisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel1 = new Personel();
            personel1.ad = "ozu";
            personel1.soyad = "kawa";
            personel1.tckn = "458188292";

            //nesne kopyalama
            Personel personel2;
            personel2 = personel1;

            //ilk kopyalama sonucu
            Console.WriteLine("personel1 = " + personel1.ad + " personel2 = " + personel2.ad);//çıktı: ozu

            //personel1 üzerindeki ilk değişiklik
            personel1.ad = "tomato";

            Console.WriteLine("-----------------------------------------");
            //personel1.ad değişiklik sonucu
            Console.WriteLine("personel1 = " + personel1.ad + " personel2 = " + personel2.ad);//çıktı: tomato

            //personel2.ad değişikliği
            personel2.ad = "watermelon";

            Console.WriteLine("-------------------------------------------");

            //personel2.ad değişiklik sonucu
            Console.WriteLine("personel1 = " + personel1.ad + " personel2 = " + personel2.ad);//çıktı: watermelon

            /*Sonuç olarak kopyalama sonucu iki nesne de birbirine bağlıdır. personel1 veya 
             personel2 deki herhangi bir değişiklik iki nesneyi de doğrudan etkiler.*/

            Console.ReadLine();
        }
    }
}

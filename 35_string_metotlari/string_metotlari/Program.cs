using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_metotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "DeNeMe ";

            Console.WriteLine("boşluk karakteri sil: " + metin.Trim());
            Console.WriteLine("tüm karakterleri küçült: " + metin.ToLower());
            Console.WriteLine("tüm karakterleri büyüt: " + metin.ToUpper());
            Console.WriteLine("metin karakter sayısı: " + metin.Length);
            Console.WriteLine("3. karakterden sonrasını sil: " + metin.Remove(3));
            Console.WriteLine("2. karakterden sonra 2 karakter sil: " + metin.Remove(2,2));
            Console.WriteLine("-Ne- karakterlerini -ZZ- ile değiştir: " + metin.Replace("Ne", "ZZ"));

            Console.ReadLine();
        }
    }
}

using System;

namespace sinif_ekle
{
    class Program
    {
        static void Main(string[] args)
        {
            Silindir silindir = new Silindir();
            
            Console.Write("Yükseklik: ");
            double yukseklik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yarıçapı giriniz: ");
            double yaricap = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hacim = " + silindir.hacim(yukseklik, yaricap));

            Console.ReadLine();
        }
    }
}

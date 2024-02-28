using System;

namespace rastgele_sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ras = new Random(); //Random() sınıfından ras isimli bir nesne oluşturulur
            int s1 = ras.Next(); //pozitif her hangi bir tamsayı
            int s2 = ras.Next(10); //1-10 arası bir tamsayı
            int s3 = ras.Next(10, 49); //10-49 arası bir tamsayı
            double s4 = ras.NextDouble(); // 0-1 arası ondalıklı sayı

            Console.WriteLine($"{s1} {s2} {s3} {s4}");

            Console.ReadLine();
        }
    }
}

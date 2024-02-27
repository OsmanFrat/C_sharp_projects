using System;

namespace dizi_elemanlarinin_konsola_yazilmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // takım isimli 5 elemanlı bir dizi
            string[] takim = new string[5];

            // dizinin elemanlarını atama
            takim[0] = "ali";
            takim[1] = "veli";
            takim[2] = "ahmet";
            takim[3] = "mehmet";
            takim[4] = "osman";

            // foreach döngüsü ile elemanları konsola alt alta yazdırma
            foreach (string eleman in takim)
            {
                Console.WriteLine(eleman);
            }

            Console.WriteLine("-----------");

            // for döngüsü ile yazma
            for(int i = 0; i < takim.Length; i++)
            {
                Console.WriteLine(takim[i]);
            }

            Console.ReadLine();
        }
    }
}

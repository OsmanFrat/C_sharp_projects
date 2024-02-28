using System;
using System.Collections.Generic;


namespace sayisal_loto
{
        class Program
        {
            static void Main(string[] args)
            {
                int[] sayisal = new int[6];
                // HashSet içinde yanlızca benzersiz(aynı eleman ikinci defa eklenemez) elemanları
                // tutan bir koleksiyon/listedir.
                HashSet<int> secilenSayilar = new HashSet<int>();

                Random ras = new Random();

                for (int i = 0; i < sayisal.Length; i++)
                {
                    int yeniSayi;
                /*ras.Next(1, 49) ile rastgele bir sayı (yeniSayi) oluşturulur.
                  secilenSayilar.Add(yeniSayi) ile HashSet içine yeniSayi eklenir. Eğer bu işlem başarılıysa 
                  (yani, daha önce eklenmemişse), Add metodu true değerini döner ve bu durumda !true ifadesi 
                  olan false ile while döngüsü sonlanır.
                  Eğer Add işlemi başarısız olursa (yani, daha önce eklenmişse), Add metodu false değerini döner
                  ve while döngüsü tekrar çalışır, yeni bir yeniSayi oluşturup eklemeye devam eder.
                  Bu yapı, secilenSayilar içinde benzersiz sayılar elde edene kadar döngünün devam etmesini sağlar.
                  Bu sayede, her döngü adımında farklı bir sayı elde edilmiş olur.*/
                do
                {
                        yeniSayi = ras.Next(1, 49);
                    } while (!secilenSayilar.Add(yeniSayi)); // Aynı sayı daha önce seçilmişse tekrar seç

                    sayisal[i] = yeniSayi;
                }

                Array.Sort(sayisal);

                for (int j = 0; j < sayisal.Length; j++)
                {
                    Console.WriteLine(j + 1 + ". sayı: " + sayisal[j]);
                }
                Console.ReadLine();
            }
        }
}


    

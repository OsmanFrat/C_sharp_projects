using System;

namespace yapici_metodlar_constructors
{
    class Daire
    {
        public Daire()
        {
            Console.WriteLine("Yapıcı metot çalıştı!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Yapıcı metodlar(constructors) bir sınıftan(class) bir nesne(object) oluşturulduğunda
             otomatik olarak çalışan metodlardır. Eğer bir nesne oluşturulduğunda bazı kodların
             herhangi bir metot çağırma işlemine gerek kalmadan otomatik olarak çalışmasını istiyorsak
             bu kodları yapıcı metot içine koyabiliriz.
             -Sınıftan bir nesne oluşturulurken parametrelerini de belirleyebiliriz
                +Örnek: Daire d = new Daire(2)
             -Yapıcı metotlar sınıfla aynı ada sahip olmalıdır.
             -Başka bir sınıf içinde kullanmak istiyorsak erişim belirteci public olmalıdır.*/

            Daire d = new Daire();

            Console.ReadLine();

        }
    }
}

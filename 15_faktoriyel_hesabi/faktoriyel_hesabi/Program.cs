﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriyel_hesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, f = 1;

            Console.WriteLine("Faktöriyelini hesaplamak istediğiniz n değerini giriniz: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                f = f * i;
            
            Console.WriteLine("Sonuç: " + n + " != " + f);

            Console.ReadLine();
        }
    }
}

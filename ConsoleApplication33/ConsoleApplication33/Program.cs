﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();
            IMuzyka osoba2 = new Osoba();
            ISport osoba3 = new Osoba();

            Console.WriteLine(((IMuzyka)osoba1).Graj());
            Console.WriteLine(osoba2.Graj());
            Console.WriteLine(osoba3.Graj());

            Console.ReadKey();
        }
    }
}

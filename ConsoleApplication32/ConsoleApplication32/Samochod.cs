using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Samochod:Pojazd, IJazda
    {
        public void Jedz()
        {
            Console.WriteLine("jadę samochodem");
        }
    }
}

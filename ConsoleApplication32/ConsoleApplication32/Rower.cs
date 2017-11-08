using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Rower:Pojazd, IJazda, IMuzyka
    {
        public void Jedz()
        {
            Console.WriteLine("jadę rowerem");
        }

        public void Klakson()
        {
            Console.WriteLine("dryń");
        }
    }
}

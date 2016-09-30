using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = 0;
            Double exp = 0;
            bool ultimate = false;
            Double expmax = level * exp;
            int chargedult = 0;

            while (true)
            {
                if (chargedult > 99)
                {
                    chargedult = 100;

                }
                char input = Console.ReadKey(true).KeyChar;
                if (input == 'x')
                {
                    exp += 1;
                    Console.WriteLine("EXP" + exp + "|" + "ULT STATUS " + chargedult + "/100");

                    chargedult += 1;
                }
            }
        }
    }
}

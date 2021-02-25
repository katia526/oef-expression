using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1 = 5;
            int getal2 = 9;
            int getal3 = 13;
            int getal4 = 20;

            if ((getal1 > getal2 && getal4 > getal3) || getal3 < getal4)
            {
                Console.WriteLine("getal1 > getal2");
            }
            else
            {
                Console.WriteLine("getal1 niet groter dan getal2");
            }
            Console.ReadLine();
        }
    }
}

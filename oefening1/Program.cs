using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef getal1: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("geef getal2: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            if ( getal1 > getal2)
            {
                Console.WriteLine($"{getal1} is het grootst");
            }
            else
            {
                Console.WriteLine($"{getal2} is het grootst");
            }
            Console.ReadLine();
        }
    }
}

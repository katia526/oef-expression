using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een getal tussen 0 en 9");
            int getal = Convert.ToInt32(Console.ReadLine());
           
            if (getal > 9)
            {
                Console.WriteLine("het getal is te groot!");
            }
            else if ((getal % 2) == 0)
            {
                Console.WriteLine("het getal is even");
            }
            else
            {
                Console.WriteLine("het getal is oneven");
            }

            Console.ReadLine();
        }
    }
}

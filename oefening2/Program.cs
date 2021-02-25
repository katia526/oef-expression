using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            if (getal >= 5)
                {
                Console.WriteLine("Geslaagd!");

            }
            else
            {
                Console.WriteLine("Gebuisd!");
            }
            Console.ReadLine();
        }
    }
}

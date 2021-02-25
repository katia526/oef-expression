using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef de prijs van de fiets: ");
            double prijs = Convert.ToDouble(Console.ReadLine());
            if (prijs >= 400)
            {
               
                double teBetalen = prijs - ((prijs *20) / 100);
                Console.WriteLine($"Prijs na 20% korting: {teBetalen}. ");
            }
            else
            {
                Console.WriteLine("sorry u krijgt geen korting");
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Heb je vandaag moeten lachen ? (Y / N)");
            string lach = Console.ReadLine();
            //bool lach = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Heb je vandaag iets productief gedaan ? (Y / N)");
            string prod = Console.ReadLine();
            //bool prod = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Scheen de zon vandaag? (Y / N)");
            string zon = Console.ReadLine();
            //bool lach = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Heb je iets lekker gegeten vandaag ? (Y / N)");
            string lekker = Console.ReadLine();
            Console.Write("Heb je iets lekker gegeten vandaag ? (Y / N)");
            string morgen = Console.ReadLine();

            if (lach == "Y")
            {
                count++;
            }
            if (prod == "Y")
            {
                count++;
            }
            if (zon == "Y")
            {
                count++;
            }
            if (lekker == "Y")
            {
                count++;
            }
            if (morgen == "Y")
            {
                count++;
            }

            if (count >= 3)
            {
                Console.WriteLine("Super! :)");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Jammer");
                Console.ReadLine();
            }

            Console.WriteLine($" u heeft {count} keer ja geantwoord");
            Console.ReadLine();
        }
    }
}

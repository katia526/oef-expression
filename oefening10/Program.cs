using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey, ik ben een chatRobot. Alles goed? kies 1 of 2");
           string keuze = Console.ReadLine();
            if (keuze == "1")
            {
                Console.WriteLine("Ja, met mij is alles ook goed?");
                Console.Write("Met mij gaat het ook goed, Wat heb je gedaan vandaag? kies 1 of 2");
                keuze = Console.ReadLine();
                if (keuze == "1")
                {
                    Console.WriteLine("Moeilijke oefeningen gemaakt! ");
                    Console.WriteLine("waren ze zoooooo moeilijk kies 1 of 2");
                    keuze = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("kinderen naar de muziekles gebracht");
                    Console.WriteLine("drukke dag?? kies 1 of 2");
                    keuze = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Neen");
                Console.WriteLine("oei, wat scheelt er? kies 1 of 2 of 3");
                keuze = Console.ReadLine();
                if (keuze == "1")
                {
                    Console.WriteLine("Moeilijke oefeningen gemaakt! ");
                    Console.WriteLine("waren ze zoooooo moeilijk kies 1 of 2 of 3 of 4");
                    keuze = Console.ReadLine();

                    if (keuze == "1")
                    {
                        Console.WriteLine("nee, had er vandaag geen zin in");
                    }
                    else if (keuze == "2")
                    {
                        Console.WriteLine("nee, was er met mijn hoofd niet bij");
                    }
                    else if (keuze == "3")
                    {
                        Console.WriteLine("ja, ze waren aardsmoeilijk");
                    }
                    else if (keuze == "4")
                    {
                        Console.WriteLine("ja, ik hoorde het ik Keulen donderen");
                    }


                }
                else if (keuze == "2")
                {
                    Console.WriteLine("kinderen naar de bomma gebracht");
                    Console.WriteLine("vreselijk drukke dag?? kies 1 of 2");
                    keuze = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("naar de winkel gereden om eten");
                    Console.WriteLine("nog zelf moeten koken?? kies 1 of 2 of 3 of 4");
                    keuze = Console.ReadLine();

                    if (keuze == "1")
                    {
                        Console.WriteLine("nee, ben dan toch maar frieten gaan halen");
                    }
                    else if (keuze == "2")
                    {
                        Console.WriteLine("nee, ben dan toch maar broodjes gaan halen");
                    }
                    else if (keuze == "3")
                    {
                        Console.WriteLine("nee, heb de pizza bezorger gebeld");
                    }
                    else if (keuze == "4")
                    {
                        Console.WriteLine("nee, ben naar de Chinees gereden");
                    }

                }
               

                
            }
            Console.ReadLine();
        }
    }
}

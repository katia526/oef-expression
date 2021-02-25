using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal1: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef een getal2: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef een getal3: ");
            int getal3 = Convert.ToInt32(Console.ReadLine());

            int temp = 0;
            

            if (getal1 > getal2) 
            {
                temp = getal1;
                getal1 = getal2;
                getal2 = temp;
            }
            
           if (getal1 > getal3)
            { 
                temp = getal1;
                getal1= getal3;
                getal3 = temp;
            }

           if (getal2 > getal3)
            {
                temp = getal2;
                getal2 = getal3;
                getal3 = temp;
            }
           
           
            Console.WriteLine($"{getal1} - {getal2} - {getal3}");
            Console.ReadLine();
        }
    }
}

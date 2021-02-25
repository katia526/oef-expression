using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("wiskunde: ");
            int wiskunde = Convert.ToInt32(Console.ReadLine());
            Console.Write("aardrijkskunde: ");
            int aard = Convert.ToInt32(Console.ReadLine());
            Console.Write("Economie: ");
            int econ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geschiedenis: ");
            int gesch = Convert.ToInt32(Console.ReadLine());
            Console.Write("wiskunde: ");
            int frans = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nederlands: ");
            int ned = Convert.ToInt32(Console.ReadLine());
            Console.Write("Engels: ");
            int eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("ICT: ");
            int ict = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            if (wiskunde < 50)
            {
                count++;
            }
            if (aard < 50)
            {
                count++;
            }
            if (econ < 50)
            {
                count++;
            }
            if (gesch < 50)
            {
                count++;
            }
            if (frans < 50)
            {
                count++;
            }
            if (ned < 50)
            {
                count++;
            }
            if (eng < 50)
            {
                count++;
            }
            if (ict < 50)
            {
                count++;
            }
            Double gemid = Convert.ToDouble(ned + frans + gesch + econ + aard + wiskunde + eng + ict) / 8;

            Console.WriteLine($"Je hebt {count} buizen");

            Console.WriteLine($"jouw gemiddelde is {gemid} ");

            Console.ReadLine();
        }
    }
}

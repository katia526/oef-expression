using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Oh nee! Het brandalarm gaat af!");
            Console.Write("is er iemand thuis? Y/N : ");
            string thuis = Console.ReadLine();
            if (thuis == "Y")
            { 
                Console.Write("heeft u de situatie onder controle? Y/N : ");
                string controle = Console.ReadLine();
                if (controle == "Y")
                {
                    Console.WriteLine("Het alarm wordt uitgeschakeld! ");
                   
                }
                else
                {
                    Console.WriteLine("De brandweer wordt verwittigd.");
                    
                }
            }
            else
            {
                Console.WriteLine("De brandweer wordt verwittigd.");
               
            }




            Console.ReadLine();
        }
    }
}

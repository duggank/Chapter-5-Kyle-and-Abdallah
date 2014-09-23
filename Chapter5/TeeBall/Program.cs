using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeeBall
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] jersey = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int playnumber;
            int playnumber2;
            int bases;
            int bases2;

            Console.Write("Enter the player number: ");
            playnumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the bases: ");
            bases = Convert.ToInt32(Console.ReadLine()); 

            for (int i = 0; i < 100; i++)
            {
                Console.Write("Enter the player number or 999 to quit: ");
                playnumber2 = Convert.ToInt32(Console.ReadLine());

                if (playnumber2 >= 999)
                    break;

                Console.Write("Enter the bases: ");
                bases2 = Convert.ToInt32(Console.ReadLine());

                if (bases >= 4 || bases2 >= 4)
                    Console.WriteLine("***Error in number of bases: 5 is too high");


                for (int j = 0; j < jersey.Length; j++)
                { 
                  
                }
            }

            Console.WriteLine("Player Summary");
        }
    }
}

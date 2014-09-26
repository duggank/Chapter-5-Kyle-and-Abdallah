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
            int userbase; 

            for (int i = 0; i < 100; i++)
            {
                Console.Write("Enter the player number or 999 to quit: ");
                playnumber = Convert.ToInt32(Console.ReadLine());

                if (playnumber >= 999)
                    break;
                for (int r = 1; r < 500; r++)
                {
                    if (playnumber > 11)
                    {
                        Console.WriteLine("Error in player number: {0}", playnumber);

                        Console.Write("Enter the player number or 999 to quit: ");
                        playnumber = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("Enter the bases: ");
                userbase = Convert.ToInt32(Console.ReadLine());

                for (int repeat = 1; repeat < 500; repeat++)
                {
                    if (userbase > 4)
                    {
                        Console.WriteLine("***Error in number of bases: {0} is too high", userbase);

                        Console.Write("Enter the bases: ");
                        userbase = Convert.ToInt32(Console.ReadLine());
                    }
                }

                for (int j = 0; j < jersey.Length; j++)
                { 
                  
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Player Summary");
            Console.WriteLine("Player:   Bases:");

        }
    }
}

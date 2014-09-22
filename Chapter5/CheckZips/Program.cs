using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zips = { 18045, 12345, 47234, 51236, 72130, 18040, 19204, 73214, 80102, 90210 };

            bool Chosen = false;

            Console.Write("Enter your zipcode: ");
            string input = Console.ReadLine();
            int userChoice = Convert.ToInt32(input);

            for (int i = 0; i < zips.Length; i++)
            {
                if (userChoice == zips[i])
                {
                    Chosen = true;
                }
            }
            if (Chosen)
                Console.WriteLine("Alright, I'll send a package straight to yo house. ");
            else
                Console.WriteLine("Not a valid zip code... Please try again.");
        }
    }
}

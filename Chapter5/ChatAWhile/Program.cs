using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] area = { 262, 414, 608, 715, 815, 920 };

            double[] cost = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };

            int userArea;
            double price = 0;
            int minutes;
            bool Valid = false;

            Console.Write("Please enter your area code: ");
            userArea = Convert.ToInt32(Console.ReadLine());

            Console.Write("Also enter how many minutes you use your phone: ");
            minutes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < area.Length; i++)
            {
                if (userArea == area[i])
                {
                    Valid = true;
                    price = minutes * cost[i];
                }
            }

            if (Valid)
                Console.WriteLine("The total cost of your call is: {0}", price.ToString("C"));
            else
                Console.WriteLine("Please enter a valid area code.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhippetBus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] distance = { 0, 100, 300, 500,};
            double[] price = { 25.00, 40.00, 55.00, 70.00 };

            int userdistance;
            double cost = 0;
            bool Valid = false;

            Console.Write("Enter how far of a distance you traveled: ");
            userdistance = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < distance.Length; i++)
            {
                if (userdistance >= distance[0] && userdistance < distance[1])
                {
                    Valid = true;
                    cost = price[0];
                }

                else if (userdistance >= distance[1] && userdistance < distance[2])
                {
                    Valid = true;
                    cost = price[1];
                }

                else if (userdistance >= distance[2] && userdistance < distance[3])
                {
                    Valid = true;
                    cost = price[2];
                }

                else if (userdistance >= distance[3])
                {
                    Valid = true;
                    cost = price[3];
                }
            }

            if (Valid)
                Console.WriteLine("The total price is: {0}", cost);
            else
                Console.WriteLine("Um.... no.");
        }
    }
}

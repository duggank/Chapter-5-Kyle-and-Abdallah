using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 30, 40, 50 };

            Console.WriteLine("These are the array values from first to last: ");
            Console.WriteLine("_____________________");
            Console.WriteLine("");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("_____________________");
            Console.WriteLine("");
            Console.WriteLine("These are the array values from last to first:");
            Console.WriteLine("_____________________");
            Console.WriteLine("");

            for (int j = array.Length-1; j >= 0; j--)
            {
                Console.WriteLine(array[j]);
            }
            Console.WriteLine("_____________________");
        }
    }
}

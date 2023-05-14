using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problems
{
    class Pattern_Que5
    {
        public static void GetPatternQue5()
        {
            int i, j;
            Console.WriteLine("Enter the number of lines you want to print the pattern: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (j = 0; j < n; j++)
            {
                for (i = 0; i < n - j; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(("\n"));
            }
        }

    }
}

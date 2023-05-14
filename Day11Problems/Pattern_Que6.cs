using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problems
{
    class Pattern_Que6
    {
        public static void GetPattern()
        {
            int i, j;
            Console.WriteLine("Enter the number of lines you want to print the pattern: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Printing the pattern
            for (j = 0; j <= n; j++)
            {
                for (i = 0; i <= n; i++)
                {
                    if (j == 0)
                        Console.Write(("*"));
                    else if (i == 0 || i == n)
                        Console.Write(("*"));
                    else if (j == n)
                        Console.Write(("*"));
                    else
                        Console.Write((" "));
                }
                Console.WriteLine(("\n"));
            }
        }
    }
}

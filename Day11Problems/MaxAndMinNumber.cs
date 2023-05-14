using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problems
{
    class MaxAndMinNumber
    {
        public static void GetMaxMinNumber()
        {

            int[] arr = { 3, 7, 1, 9, 4, 6, 8, 2, 5 };

            int max = arr[0];
            int min = arr[0];

            //loop to check max and min number one by one
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            //Print array first
            Console.Write("Elements of array: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            //print maximum and minimum number
            Console.WriteLine("\nMaximum element in the array is: " + max);
            Console.WriteLine("Minimum element in the array is: " + min);

            Console.ReadLine();
        }
    }

}

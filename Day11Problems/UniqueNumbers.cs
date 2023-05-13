using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problems
{
    class UniqueNumbers
    {
        public static void GetUniqueNumbers()
        {

            int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 1 };

            HashSet<int> uniqueElements = new HashSet<int>();

            // Add unique elements to the HashSet
            foreach (int num in array)
            {
                if (!uniqueElements.Contains(num))
                    uniqueElements.Add(num);
            }
            // Print array first
            Console.Write("Elements of array: ");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            // Print the unique elements
            Console.WriteLine("\nUnique elements in the array:");
            foreach (int num in uniqueElements)
            {
                Console.WriteLine(num);
            }
        }
    }

}


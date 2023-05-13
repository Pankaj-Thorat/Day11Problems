using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problems
{
    class DuplicateElements
    {
        public static void GetDuplicateElements()
        {
            int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 1 };

            Dictionary<int, int> countDict = new Dictionary<int, int>();

            // Count the occurrences of each element in the array
            foreach (int num in array)
            {
                if (countDict.ContainsKey(num))
                    countDict[num]++;
                else
                    countDict[num] = 1;
            }
            // Count the number of duplicate elements
            int duplicateCount = 0;
            foreach (int count in countDict.Values)
            {
                if (count > 1)
                    duplicateCount++;
            }
            // Print array first
            Console.Write("Elements of array: ");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nTotal number of duplicate elements: " + duplicateCount);
        }
    }
}
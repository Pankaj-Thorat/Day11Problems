using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problems
{
    class FrequencyOfElements
    {
        public static void GetFrequencyOfElements()
        {

            int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 1 };

            Dictionary<int, int> frequencyDict = new Dictionary<int, int>();

            // Count the frequency of each element in the array
            foreach (int num in array)
            {
                if (frequencyDict.ContainsKey(num))
                    frequencyDict[num]++;
                else
                    frequencyDict[num] = 1;
            }
            // Print array first
            Console.Write("Elements of array: ");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            // Print the frequency of each element
            Console.WriteLine("\nElement\tFrequency");
            foreach (KeyValuePair<int, int> pair in frequencyDict)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
            }
        }
    }
}


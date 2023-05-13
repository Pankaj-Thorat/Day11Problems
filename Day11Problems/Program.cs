using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //getting input from user to execute specific code
            Console.WriteLine("Please choose your program");
            Console.WriteLine("1.Duplicate Elements \n2.Unique Number \n3.Exit");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:DuplicateElements.GetDuplicateElements();
                    break;
                case 2:UniqueNumbers.GetUniqueNumbers(); 
                    break;
                default:
                    Console.WriteLine("Please try again and choose from given options only.");
                    break;
            }
        }
    }
}

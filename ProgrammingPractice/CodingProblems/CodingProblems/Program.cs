using System;
using System.Collections.Generic;
using System.Linq;
using Solvers;

namespace CodingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a list of numbers:");
            string input = Console.ReadLine();
            int[] inputArray = input.Split(" ").Select(x => int.Parse(x)).ToArray();

            LinkedList<int> numbers = new LinkedList<int>(inputArray);
            var reverser = new LinkedListReverseIterator();
            var reverse = reverser.Reverse(numbers.First);

            Console.WriteLine(PrintCollection<int>(reverse));
        }

        private static string PrintCollection<T>(IEnumerable<T> coll)
        {
            return string.Join(",", coll);
        }
    }
}

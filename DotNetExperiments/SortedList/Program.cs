using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedList = new SortedList<int, string>();

            var value = sortedList.Values[0];

            Console.WriteLine(value);
        }
    }
}

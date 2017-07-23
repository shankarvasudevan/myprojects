using System;
using System.Collections.Generic;

namespace PracticeProblems.SortingAndSearching
{
    public class AnagramSorter
    {
        public string[] SortAnagrams(string[] input)
        {
            /*
             * O(N^2) algorithm:
             * 1. Create a dictionary to map a sorted string to a list of strings that correspond to that sorted string
             * 2. Go through each string in input
             * 3. Sort the string to generate the key
             * 4. Add to the list of strings in the values
             * 5. Go through each key in the dictionary and generate an array with the corresponding words
             */

            Dictionary<string, List<string>> anagramTable = new Dictionary<string, List<string>>();

            foreach (string word in input)
            {
                char[] wordArr = word.ToCharArray();
                Array.Sort(wordArr);
                string key = new string(wordArr);
                if (!anagramTable.ContainsKey(key))
                {
                    anagramTable.Add(key, new List<string> { word });
                }
                else 
                {
                    anagramTable[key].Add(word);
                }
            }

            string[] output = new string[input.Length];
            int i = 0;

            foreach (KeyValuePair<string,List<string>> kvp in anagramTable)
            {
                foreach (string word in kvp.Value)
                {
                    output[i++] = word;
                }
            }

            return output;
        }
    }
}

using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace CopyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTest(1000);
            RunTest(10000);
            RunTest(100000);
            RunTest(1000000);
            RunTest(10000000);
        }

        static void RunTest(int size)
        {
            var dict = CreateDictionary(size);
            CopyUsingForEachWithPreallocation(dict);
            CopyUsingForEachWithoutPreallocation(dict);
            CopyUsingCopyConstructor(dict);
        }

        static void CopyUsingForEachWithoutPreallocation(Dictionary<Foo, Bar> dict)
        {
            var sw = Stopwatch.StartNew();
            var dictCpy = new Dictionary<Foo, Bar>();
            foreach (var kvp in dict)
            {
                dictCpy.Add(kvp.Key, kvp.Value);
            }

            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine($"{nameof(CopyUsingForEachWithoutPreallocation)}: [Size: {dict.Count}, TimeInMs: {elapsed}]");
        }

        static void CopyUsingForEachWithPreallocation(Dictionary<Foo, Bar> dict)
        {
            var sw = Stopwatch.StartNew();
            var dictCpy = new Dictionary<Foo, Bar>(dict.Count);
            foreach (var kvp in dict)
            {
                dictCpy.Add(kvp.Key, kvp.Value);
            }

            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine($"{nameof(CopyUsingForEachWithPreallocation)}: [Size: {dict.Count}, TimeInMs: {elapsed}]");
        }

        static void CopyUsingCopyConstructor(Dictionary<Foo, Bar> dict)
        {
            var sw = Stopwatch.StartNew();
            var dictCpy = new Dictionary<Foo, Bar>(dict);
            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine($"{nameof(CopyUsingCopyConstructor)}: [Size: {dict.Count}, TimeInMs: {elapsed}]");
        }


        static Dictionary<Foo, Bar> CreateDictionary(int size)
        {
            var dict = new Dictionary<Foo,Bar>();
            for (int i=0; i < size; ++i)
            {
                dict.Add(new Foo { Value = i }, new Bar { Value = $"Bar-{i}"});
            }

            return dict;
        }
    }

    public class Foo
    {
        public int Value { get; set; }
    }

    public class Bar 
    {
        public string Value { get; set; }
    }
}

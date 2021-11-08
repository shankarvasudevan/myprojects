using System;
using System.Collections.Generic;

namespace TryGet
{
    class Foo
    {
        public string Value { get; set; }
    }

    class Store
    {
        private readonly Dictionary<int, Foo> _values = new Dictionary<int, Foo>();

        public Store()
        {
            _values.Add(1, new Foo { Value = "AAA" });
            _values.Add(2, new Foo { Value = "BBB" });
            _values.Add(3, new Foo { Value = "CCC" });
        }

        public bool TryGetFoo(int key, out Foo result)
        {
            return _values.TryGetValue(key, out result);
        }

        public void Print()
        {
            foreach (var kvp in _values)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value.Value}");                   
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var store = new Store();
            
            store.Print();

            if (store.TryGetFoo(2, out var foo))
            {
                foo.Value = "ZZZ"; 
            }

            store.Print();
        }
    }
}

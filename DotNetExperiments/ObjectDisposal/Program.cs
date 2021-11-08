using System;
using System.Collections.Generic;

namespace ObjectDisposal
{
	public sealed class Foo : IDisposable
	{
		private int _mValue;

		public Foo(int value)
		{
			_mValue = value;
			Console.WriteLine($"Constructing Foo {_mValue}");
		}

		public void Dispose()
		{
			Console.WriteLine($"Disposing Foo {_mValue}");
		}		
	}

    	class Program
	{
        	static void Main(string[] args)
        	{
			Console.WriteLine("Starting program");

			Dictionary<int, Foo> map = new Dictionary<int, Foo>();
			map.Add(1, new Foo(1));
			map.Add(2, new Foo(2));
			map.Add(3, new Foo(3));

			Console.WriteLine("Now deleting everything");
			
			foreach (var kvp in map)
			{
				map[kvp.Key].Dispose();
			}

			Console.WriteLine("Everything deleted from map");

			Console.WriteLine("Exiting program");
		}
        }
}


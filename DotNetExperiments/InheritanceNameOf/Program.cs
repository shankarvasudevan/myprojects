using System;
using System.Collections.Generic;

namespace InheritanceNameOf
{
    	class Program
    	{
        	static void Main(string[] args)
        	{
			List<Animal> animals = new List<Animal>();
			animals.Add(new Cat());
			animals.Add(new Dog());

			foreach (var animal in animals)
			{
				switch (animal)
				{
					case Cat c:
						Console.WriteLine($"Animal is {nameof(c.GetType())}");
						break;
					case Dog d:
						Console.WriteLine($"Animal is {nameof(d.GetType())}");
						break;
					default:
						Console.WriteLine("Unknown animal"); 
						break;	
				}
			}
        	}
    	}
	
	public class Animal { }
	public class Cat : Animal { }
    	public class Dog : Animal { }
}

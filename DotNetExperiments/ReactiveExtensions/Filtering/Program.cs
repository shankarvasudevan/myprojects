﻿using System;
using System.Reactive;
using System.Reactive.Linq;

namespace Filtering
{
    class Program
    {
        static void Main(string[] args)
        {
            IObservable<int> source = Observable.Range(1, 100).Where(x => x%5 == 0);
            IObserver<int> observer = Observer.Create<int>(
                onNext: x => Console.WriteLine($"OnNext: {x}"),
                onError: ex => Console.WriteLine($"OnError: {ex.Message}"),
                onCompleted: () => Console.WriteLine("OnCompleted"));
        
	    using (source.Subscribe(observer))
            {
                Console.WriteLine("Press ENTER to unsubscribe:");
                Console.ReadLine();
            }
	}
    }
}

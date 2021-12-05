using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Observer
{
    public class ConcreteObserver2 : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"observer 2 updated, message: {message}");
        }
    }
}

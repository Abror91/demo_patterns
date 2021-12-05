using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Observer
{
    public class ConcreteObserver1 : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"observer 1 updated, message: {message}");
        }
    }
}

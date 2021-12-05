using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Decorator
{
    public class EmailNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Notify vie email message : {message}");
        }
    }
}

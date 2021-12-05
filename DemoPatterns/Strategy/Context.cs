using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Strategy
{
    public class Context
    {
        private IStrategy _strategy { get; set; }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Execute(int a, int b)
        {
            var result = _strategy.Execute(a, b);
            Console.WriteLine("Result: " + result.ToString());
        }
    }
}

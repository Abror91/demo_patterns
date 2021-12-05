using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Strategy
{
    public class SubtractionStrategy : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
}

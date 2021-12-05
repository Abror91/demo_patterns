using DemoPatterns.Observer;
using DemoPatterns.State;
using DemoPatterns.Strategy;

namespace DemoPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyClientCode.Test(StrategyType.Addition);
            StrategyClientCode.Test(StrategyType.Substraction);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.Strategy
{
    public class StrategyClientCode
    {
        public static void Test(StrategyType type)
        {
            IStrategy strategy;
            switch (type)
            {
                case StrategyType.Addition:
                        strategy = new AdditionStrategy();
                    break;
                case StrategyType.Substraction:
                    strategy = new SubtractionStrategy();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }

            var context = new Context();
            context.SetStrategy(strategy);
            context.Execute(10, 5);
        }
    }
}
